using HotDogs.Mobile.Services;
using HotDogs.Mobile.Views;
using Prism.Unity;
using Microsoft.Practices.Unity;
using Xamarin.Forms;

namespace HotDogs.Mobile
{
    public class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            //NavigationService.NavigateAsync("MainPage?title=Hello%20from%20Xamarin.Forms");
            NavigationService.NavigateAsync("MasterPage/CustomNavigationPage/NewsPage");
        }

        protected override void RegisterTypes()
        {
            // Services
            Container.RegisterType<IStoresApiService, StoresApiService>();

            // Pages
            Container.RegisterTypeForNavigation<StoresPage>();
            Container.RegisterTypeForNavigation<MasterPage>();
            Container.RegisterTypeForNavigation<NewsPage>();
            Container.RegisterTypeForNavigation<CustomNavigationPage>();
        }
    }
}
