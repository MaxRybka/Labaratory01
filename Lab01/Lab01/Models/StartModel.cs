using System;

using System.Windows.Forms;
using Lab01.Managers;

namespace Lab01.Models
{
    class StartModel
    {
        private UserModel _user;

        private readonly DateTime periodFrom;
        private readonly DateTime periodTo;

        public StartModel(UserModel user)
        {
            _user = user;
            DateTime periodNow = DateTime.Today;
            periodFrom = new DateTime(periodNow.Year - 135, periodNow.Month, periodNow.Day, periodNow.Hour, periodNow.Minute, periodNow.Second);
            periodTo = new DateTime(periodNow.Year - 18, periodNow.Month, periodNow.Day, periodNow.Hour, periodNow.Minute, periodNow.Second);
        }

        public void Confirm(DateTime selectedTime)
        {
            if(selectedTime <= periodFrom)
            {
                MessageBox.Show("The date is invalid");
                return;
            }
            if (selectedTime >= periodTo)
            {
                MessageBox.Show("The date is invalid");
                return;
            }

            _user = new UserModel(selectedTime);
            NavigationManager.Instance.LoadResult(_user);
            NavigationManager.Instance.Navigate(ModesEnum.Result);

        }
    }
}
