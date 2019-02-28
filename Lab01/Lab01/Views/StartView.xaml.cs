
using System.Windows.Controls;
using Lab01.Models;
using Lab01.ViewModels;


namespace Lab01.Views
{
    /// <summary>
    /// Логика взаимодействия для StartView.xaml
    /// </summary>
    public partial class StartView : UserControl
    {
        private StartViewModel _startViewModel;

        public StartView(UserModel user)
        {
            InitializeComponent();
            _startViewModel = new StartViewModel(user);
            DataContext = _startViewModel;
        }
    }
}
