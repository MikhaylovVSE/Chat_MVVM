using Chat.Core;
using Chat.GUI.MVVM;
using Chat.GUI.MVVM.Commands;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Input;

namespace Chat.GUI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Commands

        private ICommand _addMessageCommand;
        public ICommand AddMessageCommand
        {
            get
            {
                if (_addMessageCommand == null)
                    _addMessageCommand = new RelayCommand(_ => { AddSampleMessage(); });

                return _addMessageCommand;
            }
        }

        private ICommand _editMessageCommand;
        public ICommand EditMessageCommand
        {
            get
            {
                if (_editMessageCommand == null)
                    _editMessageCommand = new RelayCommand(_ => { EditMessage(); });

                return _editMessageCommand;
            }
        }

        private ICommand _logInCommand;
        public ICommand LogInCommand
        {
            get
            {
                if (_logInCommand == null)
                    _logInCommand = new RelayCommand(_ => { LogIn(); });

                return _logInCommand;
            }
        }

        #endregion

        #region Properties

        private string _messageText;
        public string MessageText
        {
            get { return _messageText; }
            set
            {
                _messageText = value;
                OnPropertyChanged("MessageText");
            }
        }

        private MessageViewModel _selectedMessage;
        public MessageViewModel SelectedMessage
        {
            get { return _selectedMessage; }
            set
            {
                _selectedMessage = value;
                OnPropertyChanged("SelectedMessage");
            }
        }

        public ObservableCollection<MessageViewModel> Messages { get; set; }
        #endregion

        public MainWindowViewModel()
        {
            Messages = new ObservableCollection<MessageViewModel>();
        }

        private void AddSampleMessage()
        {
            var sampleMessage = new Message("Anonymous", MessageText, DateTime.Now);
            Messages.Add(new MessageViewModel(sampleMessage));
            MessageText = "";
        }

        private void EditMessage()
        {
            SelectedMessage.Text += " edited";
        }

        private void LogIn()
        { 
            
        }
    }
}
