using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using eShoppingXamarin.ViewModels;
using eShoppingXamarin.Services;

namespace eShoppingXamarin
{
    public partial class LanguagePage : ContentPage
    {
        public LanguagePage()
        {
            InitializeComponent();
            BindingContext = new LanguageViewModel(new AlertService());

        }
    }
}
