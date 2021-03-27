using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using eShopping.Models;
using eShoppingXamarin.Services;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace eShoppingXamarin.ViewModels
{
    public abstract class LanguageViewModel : BaseViewModel
    {
        public ObservableCollection<Tag> TagList { get; set; }
        public ICommand GetList { get; }

        private IAPIService languageService;

        public LanguageViewModel(IAlertService alertService) : base(alertService)
        {
            languageService = new APIService();
            GetList = new Command(Load);
        }
        private async void Load()
        {
            if (!(Connectivity.NetworkAccess == NetworkAccess.Internet))
            {
                await AlertService.DisplayAlertAsync("ERROR", "No internet connection");
            }
            else
            {
                var things = await languageService.GetLanguageAsync();
                TagList = things.Tags;
            }
        }
    }
}
