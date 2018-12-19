using AppDevProject2018.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
//project name
namespace AppDevProject2018
{
    public partial class App : Application
    {
        //page name
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            //This verifies what starts up first
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            //when first page is shown it then goes onto the ImagePage
            MainPage = new NavigationPage(new ImagePage());

        }
    }
}
