using System.Runtime.InteropServices;
using System.Windows.Input;
using Lab01.Models;
using Lab01.Tools;

namespace Lab01.ViewModels
{
    class ResultViewModel : ObservableItem
    {
        public ResultModel Model { get; private set; }

        private int _age = 0;
        private string _event = "null";
        private string _zodiacSign = "null";
        private string _chineseSign = "null";

        private ICommand _toStartCommand;

        public int Age
        {
            get { return _age; }
            set { ChangeAndNotify(ref _age, value, () => Age); }
        }

        public string Event
        {
            get { return _event; }
            set { ChangeAndNotify(ref _event, value, () => Event); }
        }

        public string ZodiacSign
        {
            get { return _zodiacSign; }
            set { ChangeAndNotify(ref _zodiacSign, value, () => ZodiacSign); }
        }
        public string ChineseSign
        {
            get { return _chineseSign; }
            set { ChangeAndNotify(ref _chineseSign, value, () => ChineseSign); }
        }

        public ResultViewModel(UserModel user)
        {
            Model = new ResultModel(user);
            Load();
        }

        public void Load()
        {
            Age = Model.GetAge();
            ZodiacSign = Model.GetZodiacSign();
            ChineseSign = Model.GetChineseSign();
            if (Model.IsBirthday()) Event = "Happy Birthday!!!";
        }

        public ICommand ToStartCommand
        {
            get
            {
                if (_toStartCommand == null)
                {
                    _toStartCommand = new RelayCommand<object>(ResultExecute, ResultCanExecute);
                }

                return _toStartCommand;
            }
            set { ChangeAndNotify(ref _toStartCommand, value, () => ToStartCommand); }
        }

        private void ResultExecute(object obj)
        {
            Model.ToStart();
        }

        private bool ResultCanExecute(object obj)
        {
            return true;
        }
    }
}
