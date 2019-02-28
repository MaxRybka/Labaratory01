using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Lab01.Managers;
using Lab01.Models;
using Lab01.Windows;

namespace Lab01
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow mainWindow = new MainWindow();
            UserModel user = new UserModel();
            NavigationModel navigationModel = new NavigationModel(mainWindow , user);
            NavigationManager.Instance.Initialize(navigationModel);
            mainWindow.Show();
            navigationModel.Navigate(ModesEnum.Start);
        }
    }
}
