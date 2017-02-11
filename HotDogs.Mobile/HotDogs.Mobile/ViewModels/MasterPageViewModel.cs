using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotDogs.Mobile.ViewModels
{
    public class MasterPageViewModel : BindableBase, INavigationAware
    {
        public DelegateCommand<string> NavigateCommand { get; set; }

        INavigationService _navigationService;

        public MasterPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            this.NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        private void Navigate(string pageName)
        {
            _navigationService.NavigateAsync(pageName);
        }
    }
}
