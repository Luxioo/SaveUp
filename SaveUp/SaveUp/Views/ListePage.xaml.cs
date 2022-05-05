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

        /// <summary>
        /// Makes an Simple Alert, i had to do that because i wanted to have Displays and they need an async Task
        /// </summary>
        /// <param name="Titel"></param>
        /// <param name="Text"></param>
        /// <param name="Buttontext"></param>
        /// <returns></returns>
        public async Task SimpleAlert(string Titel, string Text, string Buttontext)
        {
            await DisplayAlert(Titel, Text, Buttontext);
        }

    }
}