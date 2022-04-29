using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SaveUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListePage : ContentPage
    {
        public ListePage()
        {

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

        private void bt_ei_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());

        }

        private void bt_le_Clicked(object sender, EventArgs e)
        {

        }
    }
}