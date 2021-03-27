using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamapi.Services;
using Xamapi.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamapi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StatePage : ContentPage
    {
        public StatePage()
        {
            InitializeComponent();
            BindingContext = new StatesViewModel(new StateApiService());
        }
    }
}