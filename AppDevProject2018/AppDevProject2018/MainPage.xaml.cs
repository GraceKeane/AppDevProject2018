using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
//project name
namespace AppDevProject2018
{
    public partial class MainPage : TabbedPage
    {
        //page name
        public MainPage()
        {
            //page navigation
            new NavigationPage(new ImagePage());
        }
    }
}
