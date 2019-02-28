using System;
using System.Windows.Input;
using Lab01.Models;
using Lab01.Tools;

namespace Lab01.ViewModels
{
    class StartViewModel : ObservableItem
    {

        private DateTime _selectedDate = DateTime.Now;

        private ICommand _confirmCommand;

        public StartModel Model { get; private set; }

        public StartViewModel(UserModel user)
        {
            Model = new StartModel(user);
        }

        public DateTime SelectedDate
        {
            get { return _selectedDate; }
            set { ChangeAndNotify(ref _selectedDate, value, () => SelectedDate); }
        }


        public ICommand ConfirmCommand
        {
            get
            {
                if (_confirmCommand == null)
                {
                    _confirmCommand = new RelayCommand<object>(StartExecute, StartCanExecute);
                }

                return _confirmCommand;
            }
            set { ChangeAndNotify(ref _confirmCommand, value, () => ConfirmCommand); }
        }

        private void StartExecute(object obj)
        {
            Model.Confirm(SelectedDate);
        }

        private bool StartCanExecute(object obj)
        {
            return true;
        }
    }
}
