using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinForms02.Models;

namespace WinForms02
{
    public partial class MainChatControl : UserControl
    {
        public event Action? NewChatRequested;
        public event Action<AiChat>? ChatSelected;
        public event Action<string>? MessageSendRequested;

        public MainChatControl()
        {
            InitializeComponent();

            messagesPanel.Controls.Clear();
        }

        private void newChatButton_Click(object sender, EventArgs e)
            => NewChatRequested?.Invoke();

        private void sendButton_Click(object sender, EventArgs e)
        {
            string text = sendMsgBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(text)) return;

            sendMsgBox.Clear();
            MessageSendRequested?.Invoke(text);
        }

        public void SetUsername(string username)
            => userText.Text = username;

        public void RenderChatList(List<AiChat> chats, AiChat? selectedChat)
        {
            chatPanel.Controls.Clear();
            int top = 10;

            foreach(AiChat chat in chats)
            {
                Button chatButton = new()
                {
                    Text = chat.Title,
                    Width = chatPanel.Width - 25,
                    Height = 45,
                    Left = 10,
                    Top = top,
                    TextAlign = ContentAlignment.MiddleLeft,
                    FlatStyle = FlatStyle.Flat,
                    Tag = chat,
                    ForeColor = Color.White,
                    BackColor = selectedChat != null && chat.Id == selectedChat.Id
                                ? Color.FromArgb(102, 63, 228)
                                : Color.FromArgb(40, 20, 80)
                };
                chatButton.Click += ChatButton_Click;
                chatPanel.Controls.Add(chatButton);
                top += 50;
            }
        }

        private void ChatButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button btn) return;
            if (btn.Tag is not AiChat chat) return;
            ChatSelected?.Invoke(chat);
        }

        public void RenderMessages(AiChat? chat)
        {
            messagesPanel.Controls.Clear();
            if (chat == null) return;

            foreach (ChatMessage message in chat.Messages)
            {
                if (message.Role == "system") continue;

                Label label = new()
                {
                    AutoSize = true,
                    MaximumSize = new Size(messagesPanel.Width - 40, 0),
                    Padding = new Padding(10),
                    Margin = new Padding(10),
                    ForeColor = Color.White,
                    Text = message.Role == "user" 
                                        ? $"You: {message.Content}" 
                                        : $"AI: {message.Content}",
                    BackColor = message.Role == "user" 
                                        ? Color.FromArgb(20, 20, 20) 
                                        : Color.FromArgb(80, 20, 120)
                };

                messagesPanel.Controls.Add(label);
                ScrollToBottom();
            }
        }

        private void ScrollToBottom()
        {
            if (messagesPanel.Controls.Count == 0) return;
            Control lastControl = messagesPanel.Controls[messagesPanel.Controls.Count - 1];
            messagesPanel.ScrollControlIntoView(lastControl);
        }

        public void SendState(bool isSending)
        {
            sendButton.Enabled = !isSending;
            sendMsgBox.Enabled = !isSending;
            sendButton.Text = isSending ? "..." : ">";
        }
    }
}
