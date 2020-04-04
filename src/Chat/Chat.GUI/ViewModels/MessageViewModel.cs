using Chat.Core;
using Chat.GUI.MVVM;

namespace Chat.GUI.ViewModels
{
    public class MessageViewModel : ViewModelBase
    {
        private readonly Message _message;

        private string _author;
        public string Author
        {
            get { return _author; }
            set
            {
                _author = value;
                OnPropertyChanged("Author");
            }
        }

        private string _text;
        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged("Text");
            }
        }

        private string _timestamp;
        public string Timestamp
        {
            get { return _timestamp; }
            set
            {
                _timestamp = value;
                OnPropertyChanged("Timestamp");
            }
        }

        public MessageViewModel(Message message)
        {
            this._message = message;

            Author = message.Author;
            Text = message.Text;
            Timestamp = message.Timestamp.ToShortTimeString();
        }
    }
}
