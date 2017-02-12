using HotDogs.Mobile.Models;
using HotDogs.Mobile.Services;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.ObjectModel;

namespace HotDogs.Mobile.ViewModels
{
    public class StoresPageViewModel : BindableBase, INavigationAware
    {
        public StoresPageViewModel(INavigationService navigationService, IStoresApiService api)
        {
            _api = api;
            _navigationService = navigationService;
        }

        private readonly INavigationService _navigationService;
        private readonly IStoresApiService _api;

        private ObservableCollection<Store> _stores;

        public ObservableCollection<Store> Stores
        {
            get => _stores;
            set { SetProperty(ref _stores, value); }
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public async void OnNavigatedTo(NavigationParameters parameters)
        {
            if (Stores == null)
            {
                var result = await _api.GetAllStores();
                Stores = new ObservableCollection<Store>(result);
            }
        }
    }
}
