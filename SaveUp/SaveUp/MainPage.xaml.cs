using System;
using System.Collections.Generic;
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
        }



        public List<item> itemlist = new List<item>();



        private void bt_sp_Clicked(object sender, EventArgs e)
        {
            if (en_na.Text != "" && en_be.Text != "")
            {
                itemlist.Add(new item(en_na.Text, Convert.ToDouble(en_be.Text)));
            }
        }


        /// <summary>
        /// Event Handler für den Button zu den Einträgen der die Seite wechselt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_ei_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListePage(itemlist));
        }
    }
}
