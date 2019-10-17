using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CmdStackLayoutHorizontal_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.StackLayoutHorizontal());
        }

        private void CmdStackLayoutVertical_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.StackLayoutVertical());
        }

        private void CmdRelativeLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.RelativeLayoutExample());
        }

        private void CmdAbsoluteLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.AbsoluteLayoutExample());
        }

        private void CmdGrid_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.GridExample1());
        }

        private void CmdGridUsingGridUnitTypeAbsolute_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.GridExample2());
        }

        private void CmdGridUsingGridUnitTypeStar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.GridExample3());
        }

        private void CmdFlexLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.FlexLayoutExample());
        }

        private void CmdContentView_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.ContentViewExample());
        }

        private void CmdFrame_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.FrameExample());
        }
    }
}
