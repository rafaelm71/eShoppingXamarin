using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShoppingXamarin.ViewModels
{
    public class ProductViewModel: BaseViewModel
    {
        public override string Title => "Products";
        public ICommand ShowProductCommand { get; }

        public ProductViewModel(INavigationService navigationService) : base(navigationService)
        {
            ShowProductCommand = new Command(async () => await ExecuteShowProducts());
        }

        public Task ExecuteShowProducts()
        {
            return NavigationService.NavigateAsync("ProductPage");
        }
    }
}
