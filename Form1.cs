using WinForms02.Models;
using WinForms02.Services;

namespace WinForms02
{
    public partial class Form1 : Form
    {
        private readonly LoginControl loginControl;
        private readonly RegisterControl registerControl;
        private readonly MainChatControl mainChatControl;

        private AppDatabase database = new();
        private AppUser? currentUser;
        private AiChat? currentChat;

        public Form1()
        {
            InitializeComponent();

            loginControl = new LoginControl();
            registerControl = new RegisterControl();
            mainChatControl = new MainChatControl();

            database = DatabaseService.Load();

            loginControl.Dock = DockStyle.Fill;
            registerControl.Dock = DockStyle.Fill;
            mainChatControl.Dock = DockStyle.Fill;

            loginControl.OpenRegister += ShowRegister;
            loginControl.OnLoginRequested += LoginUser;

            registerControl.OpenLogin += ShowLogin;
            registerControl.OnSignupRequested += RegisterUser;

            mainChatControl.NewChatRequested += CreateNewChat;
            mainChatControl.ChatSelected += SelectChat;
            mainChatControl.MessageSendRequested += async text => await SendMessageToAi(text);

            ShowRegister();
        }

        private void ShowLogin()
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(loginControl);
        }
        private void ShowRegister()
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(registerControl);
        }

        private void ShowMainChat()
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(mainChatControl);
        }

        private void RegisterUser(string email, string username, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || 
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            bool userExists = database.Users.Any(u => u.Email == email || u.Username == username);

            if (userExists)
            {
                MessageBox.Show("Пользователь с таким email или именем уже существует.");
                return;
            }

            AppUser newUser = new()
            {
                Id = database.Users.Count > 0 ? database.Users.Max(u => u.Id) + 1 : 1,
                Email = email,
                Username = username,
                CreatedAt = DateTime.Now,
                Password = password
            };

            database.Users.Add(newUser);
            DatabaseService.Save(database);
            MessageBox.Show("Регистрация успешна!");
            ShowLogin();
        }

        private void LoginUser(string email, string password)
        {
            AppUser? user = database.Users.FirstOrDefault(u => u.Email == email 
                                                            && u.Password == password);
            if (user == null)
            {
                MessageBox.Show("Неверный email или пароль.");
                return;
            }
            currentUser = user;
            currentChat = currentUser.Chats.FirstOrDefault();
            MessageBox.Show($"Добро пожаловать, {currentUser.Username}!");
            ShowMainChat();
            RefreshMainChat();
        }

        private void RefreshMainChat()
        {
            if (currentUser == null) return;
            mainChatControl.SetUsername(currentUser.Username);
            mainChatControl.RenderChatList(currentUser.Chats, currentChat);
            mainChatControl.RenderMessages(currentChat);
        }

        private void CreateNewChat()
        {
            if (currentUser == null)
            {
                MessageBox.Show("Пользователь не вошёл в акканут!");
                return;
            }

            int newChatId = currentUser.Chats.Count > 0 
                                ? currentUser.Chats.Max(c => c.Id) + 1 : 1;

            AiChat newChat = new()
            {
                Id = newChatId,
                Title = "Новый чат",
                CreatedAt = DateTime.Now,
                Messages = [
                    new() {
                        Role = "system",
                        Content = "Ты - мой персональный помощник. Помоги мне с любыми вопросами и задачами, которые у меня есть."
                    }
                ]
            };

            currentUser.Chats.Add(newChat);
            currentChat = newChat;
            DatabaseService.Save(database);
            RefreshMainChat();
        }

        private void SelectChat(AiChat chat)
        {
            currentChat = chat;
            RefreshMainChat();
        }

        private void AddTestMessage(string text)
        {
            if (currentChat == null)
            {
                MessageBox.Show("Обязательно создайте чат перед отправкой сообщения!");
                return;
            }

            currentChat.Messages.Add(new()
            {
                Role = "user",
                Content = text
            });

            currentChat.Messages.Add(new()
            {
                Role = "assistant",
                Content = "Типа ответила нейронка"
            });

            if (currentChat.Title == "Новый чат")
            {
                currentChat.Title = text.Length > 20 
                                ? string.Concat(text.AsSpan(0, 20), "...")
                                : text;
            }

            DatabaseService.Save(database);
            RefreshMainChat();
        }

        private void LimitChatHistory(AiChat chat)
        {
            int maxMessages = 100;
            if (chat.Messages.Count <= maxMessages) return;
            int removeCount = chat.Messages.Count - maxMessages;
            chat.Messages.RemoveRange(1, removeCount);
        }

        private async Task SendMessageToAi(string text)
        {
            if (currentChat == null || currentUser == null)
            {
                MessageBox.Show("Пользователь не вошёл в акканут или чат не выбран!", "Да-Да-Да");
                return;
            }

            currentChat.Messages.Add(new()
            {
                Role = "user",
                Content = text
            });

            if (currentChat.Title == "Новый чат")
            {
                currentChat.Title = text.Length > 20
                                ? string.Concat(text.AsSpan(0, 20), "...")
                                : text;
            }

            DatabaseService.Save(database);
            RefreshMainChat();

            try
            {
                mainChatControl.SendState(true);
                string? answer = await AiService.SendAsync(currentChat.Messages);
                if (string.IsNullOrWhiteSpace(answer))
                {
                    currentChat.Messages.RemoveAt(currentChat.Messages.Count - 1);
                    DatabaseService.Save(database);
                    RefreshMainChat();
                    MessageBox.Show("Нейронка не ответила :<");
                    return;
                }

                currentChat.Messages.Add(new()
                {
                    Role = "assistant",
                    Content = answer
                });

                LimitChatHistory(currentChat);
                DatabaseService.Save(database);
                RefreshMainChat();
            }
            catch (Exception ex)
            {
                currentChat.Messages.RemoveAt(currentChat.Messages.Count - 1);
                DatabaseService.Save(database);
                RefreshMainChat();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mainChatControl.SendState(false);
            }

        }

    }
}
