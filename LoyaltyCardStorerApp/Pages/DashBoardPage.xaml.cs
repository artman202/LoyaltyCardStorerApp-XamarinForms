using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Forms;

namespace LoyaltyCardStorerApp.Pages
{
    public partial class DashBoardPage : ContentPage, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DashBoardPage()
        {
            InitializeComponent();

            takePhoto.Clicked += async (sender, args) =>
	        {
                if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
	            {
	                await DisplayAlert("No Camera", ":( No camera avaialble.", "OK");
	                return;
	            }

                var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions());

	            if (file == null)
	                return;

	            //await DisplayAlert("File Location", file.Path, "OK");

             //   image.Source = ImageSource.FromStream(() =>
	            //{
	            //    var stream = file.GetStream();
	            //    file.Dispose();
	            //    return stream;
	            //});

                var bytes = GetByteArr(file);

				var image = new Image
				{
					Source = ImageSource.FromStream(() => new MemoryStream(bytes))
				};

                (BindingContext as DashBoardPageModel).SetSource(image.Source);

                System.Diagnostics.Debug.WriteLine(bytes);
	        };
        }

        public byte[] GetByteArr(MediaFile file)
        {
            var memoryStream = new MemoryStream();
                
			file.GetStream().CopyTo(memoryStream);
			file.Dispose();
			return memoryStream.ToArray();
        }
    }
}
