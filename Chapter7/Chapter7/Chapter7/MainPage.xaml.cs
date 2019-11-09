using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter7
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CmdNavigationPage1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage1());
        }

        private void CmdDropdownMenu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DropdownMenu());
        }

        private void CmdAlerts_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Alerts());
        }

        private void CmdPopupMenu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PopupMenu());
        }

        private void CmdDrilldownListViewByItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DrilldownListViewByItem());
        }

        private void CmdDrilldownListViewByPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DrilldownListViewByPage());
        }

        private void CmdDrilldownTableView_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DrilldownTableView());
        }

        private void CmdTabPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TabPage());
        }

        private void CmdTabPageDatabound_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TabPageDatabound());
        }

        private void CmdSpringboard_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Springboard());
        }

        private void CmdCarousel_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Carousel());
        }

        private void CmdPropertiesPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PropertiesPage1());
        }
    }
}
