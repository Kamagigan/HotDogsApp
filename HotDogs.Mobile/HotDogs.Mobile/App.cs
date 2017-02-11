using HotDogs.Mobile.Views;
using Prism.Unity;
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
            //Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<StoresPage>();
            Container.RegisterTypeForNavigation<MasterPage>();
            Container.RegisterTypeForNavigation<NewsPage>();
            Container.RegisterTypeForNavigation<CustomNavigationPage>();
        }
    }
}
