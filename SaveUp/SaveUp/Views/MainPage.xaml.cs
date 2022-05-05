using SaveUp.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace SaveUp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }

        public MainPage(ObservableCollection<item> temp)
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel(temp);
        }

    }
}
