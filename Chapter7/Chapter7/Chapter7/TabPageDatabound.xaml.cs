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
    public partial class TabPageDatabound : TabbedPage
    {
        public TabPageDatabound ()
        {
            InitializeComponent();
            this.ItemsSource = new TabItem[] {
             new TabItem ("First", 1),
             new TabItem ("Second", 2),
             new TabItem ("Third", 3),
             new TabItem ("Fourth", 4),
             new TabItem ("Fifth", 5),
             new TabItem ("Sixth", 6)
             };
        }
    }
}