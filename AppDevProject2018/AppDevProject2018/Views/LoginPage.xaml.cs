using AppDevProject2018.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//project name.views
namespace AppDevProject2018.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        //Page name
        public LoginPage()
        {
            //initializes all the components specified in the xaml page
            InitializeComponent();
            Init();
        }
        void Init()
        {
            //page design
            BackgroundColor = Constants.BackgroundColor;
            Lb1_Password.TextColor = Constants.MainTextColor;
            Lb1_Username.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcedure(s,e);
        }
        //sign up procedure code
        private async void SignInProcedure(object sender, EventArgs e)
        {
            //when button is cliked it will go onto the next page
            await Navigation.PushAsync(new ImagePage());

            User user = new User(Entry_Username.Text, Entry_Password.Text);

            //checking information in user page
            if (user.CheckInformation())
            {
                //if sign up info successful it will output this alert
                DisplayAlert("Sign Up", "Welcome! " + Entry_Username.Text + " You have signed up successfully, Hope you enjoy learning about the diferant wild animals of Ireland!", "Okay");
            }
            else
            {
                //if sign up info not successful it will output this alert
                DisplayAlert("Sign Up", "Sign up not successful, Please try again", "Okay");
            }
        }   
    }   
}
