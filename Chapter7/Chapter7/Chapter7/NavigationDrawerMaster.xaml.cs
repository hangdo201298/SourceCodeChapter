using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationDrawerMaster : ContentPage
    {
        public ListView ListView;

        public NavigationDrawerMaster()
        {
            InitializeComponent();

            BindingContext = new NavigationDrawerMasterViewModel();
            ListView = MenuItemsListView;
        }

        class NavigationDrawerMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<NavigationDrawerMenuItem> MenuItems { get; set; }
            
            public NavigationDrawerMasterViewModel()
            {
                MenuItems = new ObservableCollection<NavigationDrawerMenuItem>(new[]
                {
                    new NavigationDrawerMenuItem { Id = 0, Title = "Page 1" },
                    new NavigationDrawerMenuItem { Id = 1, Title = "Page 2" },
                    new NavigationDrawerMenuItem { Id = 2, Title = "Page 3" },
                    new NavigationDrawerMenuItem { Id = 3, Title = "Page 4" },
                    new NavigationDrawerMenuItem { Id = 4, Title = "Page 5" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}