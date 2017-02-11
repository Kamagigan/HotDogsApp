using System;
using Prism.Navigation;
using Xamarin.Forms;

namespace HotDogs.Mobile.Views
{
    public partial class CustomNavigationPage : NavigationPage, INavigationPageOptions
    {
        public CustomNavigationPage()
        {
            InitializeComponent();
        }

        // Continue d'ajouter les pages evrs lesquels on navigue dans le stack
        // Returns false permets de prévenir la "fausse" navigation d'une page MatserDetail en tant que page root
        public bool ClearNavigationStackOnNavigation
        {
            get { return false; }
        }
    }
}
