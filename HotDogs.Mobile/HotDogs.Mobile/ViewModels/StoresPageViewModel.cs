using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotDogs.Mobile.ViewModels
{
    public class StoresPageViewModel : BindableBase
    {
        public StoresPageViewModel()
        {
            Text = "Hello you !";
        }

        private string _text;

        public string Text
        {
            get { return this._text; }
            set { SetProperty(ref _text, value); }
        }

    }
}
