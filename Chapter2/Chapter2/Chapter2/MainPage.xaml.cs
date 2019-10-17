using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CmdStaticPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StaticPage());
        }

        private void CmdArrayPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ArrayPage());
        }

        private void CmdReferencePage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReferencePage());
        }

        private void CmdConstructorsPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConstructorsPage());
        }

        private void CmdPropertyValuesPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PropertyValuesPage());
        }
    }
}
