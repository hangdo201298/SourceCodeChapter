using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CmdControls_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Controls());
        }

        private void CmdMyClass_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyClass());
        }

        private void CmdHomePage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }

        private void CmdMyTriggers_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyClassTriggers());

        }
    }
}
