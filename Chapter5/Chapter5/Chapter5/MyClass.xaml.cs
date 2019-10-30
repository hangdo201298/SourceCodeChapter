using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter5
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyClass : ContentPage
	{
		public MyClass ()
		{
			InitializeComponent ();
		}
	}
}