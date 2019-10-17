using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter4_Style
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CmdFeedbackPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FeedbackPage());
        }

        private void CmdStaticResourcesPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StaticResourcesPage());
        }

        private void CmdDynamicResourcesPag_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DynamicResourcesPage());
        }

        private void CmdExplicitStylePage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ExplicitStylePage());
        }

        private void CmdImplicitStylePage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ImplicitStylePage());
        }

        private void CmdOverridingStylesPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OverridingStylesPage());
        }

        private void ButtonStylesPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ButtonStylesWithResourcesPage());
        }

        private void CmdButtonStylesWithStaticInheritancePage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ButtonStylesWithStaticInheritancePage());
        }

        private void CmdButtonStylesWithDynamicInheritancePage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ButtonStylesWithDynamicInheritancePage());
        }

        private void CmdStylesPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StylePage());
        }

        private void CmdDeviceStylePage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DeviceStylePage());
        }

        private void CmdDarkThemePage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DarkThemePage());
        }

        private void CmdLightThemePage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LightThemePage());
        }

        private void CmdCustomDarkThemePage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CustomDarkThemePage());
        }

        private void CmdCSSPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CSSPage());
        }
    }
}
