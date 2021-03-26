using System;
using System.Collections.Generic;
using System.Text;
using eShoppingXamarin.Services;
using System.ComponentModel;

namespace eShoppingXamarin.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected IAlertService AlertService { get; }
        protected BaseViewModel(IAlertService alertService)
        {
            AlertService = alertService;
        }
    }
}