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
        public ListePage(List<item> itemliste)
        {
            string x = "";
            InitializeComponent();
            foreach (var item in itemliste)
            {
                x += $" {item.name}  {item.betrag}  {item.uhrzeit} \n";
            }
            ed_te.Text = x;
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

                throw;
            }
        }

        private void bt_ei_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());

        }
    }
}