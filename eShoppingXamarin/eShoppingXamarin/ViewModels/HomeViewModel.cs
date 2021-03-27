using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShoppingXamarin.ViewModels
{
    public class HomeViewModel: BaseViewModel
    {
        public override string Title => "Home";
        public ICommand ShowProductCommand { get; }

        public HomeViewModel(INavigationService navigationService) : base(navigationService)
        {
            ShowProductCommand = new Command(async () => await ExecuteShowProducts());
        }

        public Task ExecuteShowProducts()
        {
            return NavigationService.NavigateAsync("ProductPage");
        }
    }
}
