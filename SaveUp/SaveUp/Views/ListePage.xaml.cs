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
        public List<item> Itemliste = new List<item>();
        public ListePage(List<item> dieitemlistepara)
        {
            string x = "";
            InitializeComponent();
            foreach (var item in dieitemlistepara)
            {
                x += $" {item.name}  {item.betrag}  {item.uhrzeit} \n";
            }
            ed_te.Text = x;

            Itemliste = dieitemlistepara;
        }

        private void bt_sp_Clicked(object sender, EventArgs e)
        {
            string pfad = @"c:\temp\Storage.txt";
            try
            {
                if (File.Exists(pfad) == false)
                {
                    StreamWriter writer1;
                    writer1 = File.CreateText(pfad);
                }


                StreamReader reader = new StreamReader(pfad);
            }
            catch (Exception)
            {
                SimpleAlert("Fehler", "Etwas ist schiefgelaufen!", "OK");
            }
        }

        /// <summary>
        /// Makes an Simple Alert, i had to do that because i wanted to have Displays and they need an async Task
        /// </summary>
        /// <param name="Titel"></param>
        /// <param name="Text"></param>
        /// <param name="Buttontext"></param>
        /// <returns></returns>
        private async Task SimpleAlert(string Titel, string Text, string Buttontext)
        {
            await DisplayAlert(Titel, Text, Buttontext);
        }

        private void bt_ei_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());

        }

        private void bt_le_Clicked(object sender, EventArgs e)
        {
            /*
            Itemliste.Clear();
            */
        }
    }
}