using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using SaveUp.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SaveUp
{
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListePage : ContentPage
    {
        public ListePage(ObservableCollection<item> temp)
        {
            InitializeComponent();
            this.BindingContext = new ListePageViewModel(temp);
        }

    }
}