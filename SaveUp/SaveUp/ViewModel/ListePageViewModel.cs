using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace SaveUp.ViewModel
{
    class ListePageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<item> ItemListe { get; set; } = new ObservableCollection<item>();

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Container mit den Daten
        /// </summary>
        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ListePageViewModel(ObservableCollection<item> temp)
        {
            Commandlisteleeren = new Command(Command3);
            Commandspeichern = new Command(Command4);
            CommandzurückHauptseite = new Command(Command5);
            ItemListe = temp;
        }




        async void Command3()
        {
            ItemListe.Clear();
        }

        /// <summary>
        ///  
        /// </summary>
        async void Command4()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        async void Command5()
        {
            Application.Current.MainPage = new NavigationPage(new MainPage(ItemListe));

        }


        /// <summary>
        /// Command to clear the list in the container
        /// </summary>

        public Command Commandlisteleeren { get; }

        /// <summary>
        /// Command to save the data it could maybe be cancelled
        /// </summary>
        public Command Commandspeichern { get; }

        /// <summary>
        /// Command to get back to the MainPage
        /// </summary>
        public Command CommandzurückHauptseite { get; }



    }
}
