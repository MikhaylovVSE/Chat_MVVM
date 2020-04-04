using System;

namespace Chat.Core
{
    [Serializable]
    public class Message
    {
        public string Author { get; }
        public string Text { get; }
        public DateTime Timestamp { get; }

        public Message(string author, string text, DateTime timestamp)
        {
            Author = author;
            Text = text;
            Timestamp = timestamp;
        }
    }
}
