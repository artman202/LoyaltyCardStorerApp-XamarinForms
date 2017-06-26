using System;
using System.ComponentModel;
using FreshMvvm;

namespace LoyaltyCardStorerApp.Pages
{
    public class BasePageModel : FreshBasePageModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
