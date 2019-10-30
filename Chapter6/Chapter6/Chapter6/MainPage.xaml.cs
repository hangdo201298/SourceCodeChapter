using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CmdListViewStrings_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewStrings());
        }

        private void CmdListViewDataModel_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewDataModel());
        }

        private void CmdListViewImageCell_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewImageCell());
        }

        private void CmdListViewCustom_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewCustom());
        }

        private void CmdListViewButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewButton());
        }

        private void CmdListViewContextAction_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewContextAction());
        }

        private void CmdListViewGrouped_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewGrouped());
        }

        private void CmdListViewGroupedTemplate_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewGroupedTemplate());
        }

        private void CmdListViewScroll_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewScroll());
        }

        private void CmdListViewPerformance_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewPerformance());
        }

        private void CmdListViewCustomWithImage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewCustomWithImage());
        }
    }
}
