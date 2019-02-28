
using System.Windows.Controls;
using Lab01.Models;
using Lab01.ViewModels;



namespace Lab01.Views
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class ResultView: UserControl
    {
        private ResultViewModel _resultViewModel;

        public ResultView(UserModel user)
        {
            InitializeComponent();
            _resultViewModel = new ResultViewModel(user);
            DataContext = _resultViewModel;
        }

    }
}
