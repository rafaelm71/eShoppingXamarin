using System;
using System.Collections.Generic;
using System.Text;
using eShoppingXamarin.Services;
using System.ComponentModel;
using Prism.Navigation;

namespace eShoppingXamarin.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected IAlertService AlertService { get; }
        protected BaseViewModel(IAlertService alertService)
        {
            AlertService = alertService;
        }

        public abstract string Title { get; }
       

        protected INavigationService NavigationService { get; }

        protected BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }


    }
}