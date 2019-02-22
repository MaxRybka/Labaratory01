using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        //private Result _resultView;


        public NavigationModel(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            _startView = new StartView();
        }

        public void Navigate(ModesEnum mode)
        {
            switch (mode)
            {
                case ModesEnum.Start:
                    _mainWindow.ContentControl.Content = _startView;
                    break;
                //case ModesEnum.Result:
                //    _mainWindow.ContentControl.Content = _resultView;
                //    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
        }
    }
}
