using Chat.Core;
using Chat.GUI.MVVM;
using Chat.GUI.MVVM.Commands;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Chat.GUI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<MessageViewModel> Messages { get; set; }

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

        public MainWindowViewModel()
        {
            Messages = new ObservableCollection<MessageViewModel>();
        }

        private void AddSampleMessage()
        {
            var sampleMessage = new Message("Anonymous", "Big Brother is watching you.", DateTime.Now);
            Messages.Add(new MessageViewModel(sampleMessage));
        }
    }
}
