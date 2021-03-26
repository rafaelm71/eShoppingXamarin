using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShoppingXamarin.Services
{
    public class AlertService : IAlertService
    {
        public Task DisplayAlertAsync(string title, string message)
        {
            return App.Current.MainPage.DisplayAlert(title, message, "OK");
        }
    }
}
