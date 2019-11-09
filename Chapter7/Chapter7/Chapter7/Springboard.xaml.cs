using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter7
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Springboard : ContentPage
	{
        public Springboard()
        {
            InitializeComponent();

            var tapFirst = new TapGestureRecognizer();
            tapFirst.Tapped += async (s, e) =>
            {
                //firstImage.Opacity = .5;  // dim the image for user feedback when tapped
                //await Task.Delay(100);
                //firstImage.Opacity = 1;
                await this.Navigation.PushAsync(new NavigationPage1());
            };
            FirstImage.GestureRecognizers.Add(tapFirst);

            var tapSecond = new TapGestureRecognizer();
            tapSecond.Tapped += async (s, e) =>
            {
                await this.Navigation.PushAsync(new SecondPage());
            };
            SecondImage.GestureRecognizers.Add(tapSecond);

            var tapThird = new TapGestureRecognizer();
            tapThird.Tapped += async (s, e) =>
            {
                await this.Navigation.PushAsync(new ThirdPage());
            };
            ThirdImage.GestureRecognizers.Add(tapThird);
        }
    }
}