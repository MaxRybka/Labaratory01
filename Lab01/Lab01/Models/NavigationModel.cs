using System;
using Lab01.Views;
using Lab01.Windows;

namespace Lab01.Models
{

    public enum ModesEnum
    {
        Start,
        Result
    }

    class NavigationModel
    {
        private MainWindow _mainWindow;
        private StartView _startView;
        private ResultView _resultView;


        public NavigationModel(MainWindow mainWindow , UserModel user)
        {
            _mainWindow = mainWindow;
            _startView = new StartView(user);
            _resultView = new ResultView(user);
        }

        public void Navigate(ModesEnum mode)
        {
            switch (mode)
            {
                case ModesEnum.Start:
                    _mainWindow.ContentControl.Content = _startView;
                    break;
                case ModesEnum.Result:
                    _mainWindow.ContentControl.Content = _resultView;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
        }

        public void LoadResult(UserModel user)
        {
            _resultView = new ResultView(user);
        }
    }
}
