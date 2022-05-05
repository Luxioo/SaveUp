using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace SaveUp.ViewModel
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Container mit den Daten
        /// </summary>
        /// 
        public ObservableCollection<item> ItemListe { get; set; }

        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        /// <summary>
        /// Ctor für das erste Mal
        /// </summary>
        public MainPageViewModel()
        {
            // Commands
            CommandEintragspeichern = new Command(Command1);
            CommandNächsteseite = new Command(Command2);
            Commandlisteleeren = new Command(Command3);
            Commandspeichern = new Command(Command4);
            CommandzurückHauptseite = new Command(Command5);
            ItemListe = new ObservableCollection<item>();
        }
        /// <summary>
        /// Ctor falls man wieder auf die Seite verweisst
        /// </summary>
        /// <param name="temp"></param>
        public MainPageViewModel(ObservableCollection<item> temp)
        {
            CommandEintragspeichern = new Command(Command1);
            CommandNächsteseite = new Command(Command2);
            Commandlisteleeren = new Command(Command3);
            Commandspeichern = new Command(Command4);
            CommandzurückHauptseite = new Command(Command5);
            ItemListe = temp;
        }


        /*
        private List<item> itemliste;

        public List<item> ItemListe
        {
            get { return itemliste; }
            set 
            { 
                itemliste = value; 
                OnPropertyChanged();
            }
        }
        */


        private string name;

        public string Name
        {
            get { return name; }
            set 
            {
                name = value;
                OnPropertyChanged();
            }
        }



        private string betrag;

        public string Betrag
        {
            get { return betrag; }
            set
            {
                betrag = value;
                OnPropertyChanged();
            }
        }

        private string listeasstring;

        public string ListeasString
        {
            get { return listeasstring; }
            set
            {
                ListeasString = value;
                OnPropertyChanged();
            }
        }

        // Commands

        /// <summary>
        /// Saved the items in the list in the Datacontainer
        /// </summary>
        async void Command1()
        {
            if (Name != "" && Convert.ToDouble(Betrag) > 0)
            {
                ItemListe.Add(new item(Name, Convert.ToDouble(Betrag)));
            }
            else
            {

            }
        }

        /// <summary>
        /// 
        /// </summary>
        async void Command2()
        {

            Application.Current.MainPage = new NavigationPage(new ListePage(ItemListe));
        }

        // Page 2

        /// <summary>
        /// 
        /// </summary>

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

        public Command CommandEintragspeichern { get; }
        public Command CommandNächsteseite { get; }


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
