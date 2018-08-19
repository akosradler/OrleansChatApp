using System;

namespace OrleansChatApp.Models
{
    [Serializable]
    public class ChatMessage
    {
        public DateTimeOffset Created { get; set; } = DateTimeOffset.Now;
        public int UserId { get; set; }
        public string Text { get; set; }

        public ChatMessage(int userId, string message)
        {
            UserId = userId;
            Text = message;
        }
    }
}