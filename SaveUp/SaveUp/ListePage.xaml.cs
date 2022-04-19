using System;
using System.Collections.Generic;
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
    }
}