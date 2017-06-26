using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace LoyaltyCardStorerApp.Pages
{
    public class DashBoardPageModel : BasePageModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ImageSource _source;
        public ImageSource Source { 
            get => this._source;
            set 
            {
                if (value != this._source)
				{
					this._source = value;
					OnPropertyChanged("Source");
				}
            } 
        }

        public DashBoardPageModel()
        {
        }

        public void SetSource(ImageSource source)
        {
            Source = source;
        }

        public virtual void OnPropertyChanged(string propertyName)
        {
            var propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
