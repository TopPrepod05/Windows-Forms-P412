namespace WinForms02.Models
{
    public class AiChat
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public List<ChatMessage> Messages { get; set; } = [];

    }
}
