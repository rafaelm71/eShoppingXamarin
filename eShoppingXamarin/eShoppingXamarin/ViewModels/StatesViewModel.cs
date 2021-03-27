using eShoppingXamarin;
using eShoppingXamarin.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamapi.Services;
using Xamarin.Essentials;

namespace Xamapi.ViewModels
{
    public class StatesViewModel: INotifyPropertyChanged
    {
        public ObservableCollection<IList<StateInfo>> States { get; } = new ObservableCollection<IList<StateInfo>>();
     
        public bool IsBusy { get; set; }
        public bool IsNotBusy => !IsBusy;
        private IStateApiService _stateApiService;
        public StatesViewModel(IStateApiService stateApiService)
        {
            _stateApiService = stateApiService;
            InternetCheck();
        }
        
        private async void InternetCheck()
        {
            IsBusy = true;
            if (!(Connectivity.NetworkAccess== NetworkAccess.Internet))
            {
                await App.Current.MainPage.DisplayAlert("Error", "No hay conexion a internet, intentelo de nuevo cuando tenga conexion a internet","Ok");
            }
            else
            {
                var stateapi = await _stateApiService.GetStateAsync();
                States.Add((IList<StateInfo>)stateapi.Tags);
            }
            IsBusy = false;
        }
        /*
        async Task LoadStates()
        {
            IsBusy = true;
            var stateInfo = await _stateApiService.GetStateAsync();
            if(stateInfo != null)
            {
                foreach(var d in stateInfo.Tags)
                {
                    States.Add((IList<StateInfo>)d);
                }
            }
            IsBusy = false;
        }
        */
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
