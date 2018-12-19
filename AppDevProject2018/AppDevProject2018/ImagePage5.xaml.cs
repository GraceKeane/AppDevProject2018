using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//project name
namespace AppDevProject2018
{ 
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage5 : ContentPage
    {
        //page name
        public ImagePage5()
        {
            InitializeComponent();
            //displaying image using image address (embedded image)
            image.Source = ImageSource.FromResource("AppDevProject2018.Images.Stoat.jpg");
        }

        //Tap gesture to allow the user to tap the image which brings them onto another page
        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            //specifying what page it will go onto
            await Navigation.PushAsync(new ImagePage6());
        }

    }
}