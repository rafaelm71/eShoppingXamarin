using ApiXamarin.Services;
using eShopping.Models;
using eShoppingXamarin;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using eShoppingXamarin.Models;


namespace ApiXamarin.ViewModels
{
    public class IIngredientAnalysisViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<eShopping.Models.Tag> Ingredients { get; set; }
        
        private IIngredientAnalysisApiService _IngredientAnalysisApiService;
        

        public bool IsBusy { get; set; }
        public bool IsNotBusy => !IsBusy;
        public IIngredientAnalysisViewModel(IIngredientAnalysisApiService ingredientAnalysisApiService)
        {
            _IngredientAnalysisApiService = ingredientAnalysisApiService;
            LoadIngredients();

        }
       async Task LoadIngredients()
        {
            IsBusy = true;
            if(Connectivity.NetworkAccess == NetworkAccess.Internet) { 
           var ingredientAnalysis1 = await _IngredientAnalysisApiService.GetIngredientAnalysisAsync();
            if(ingredientAnalysis1 != null)
            {
                foreach(var ingredientAnalysis in ingredientAnalysis1.Tags)
                {
                    Ingredients.Add(ingredientAnalysis);
                }

               
            }
           }
            else
            {
                await DisplayAlert("Alert", "You have been alerted", "OK");
            }
            IsBusy = false;
        }

        private Task DisplayAlert(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
