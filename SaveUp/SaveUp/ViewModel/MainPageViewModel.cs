using System;
using System.Collections.Generic;
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
        public Datacontainer Container = new Datacontainer();
        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public MainPageViewModel()
        {
            // Commands
            CommandEintragspeichern = new Command(Command1);
            CommandNächsteseite = new Command(Command2);

        }

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

        // Commands

        /// <summary>
        /// Saved the items in the list in the Datacontainer
        /// </summary>
        async void Command1()
        {
            if (Name != "" && Convert.ToDouble(Betrag) > 0)
            {
                Container.itemliste.Add(new item(Name, Convert.ToDouble(Betrag)));
            }
        }

        async void Command2()
        {
            Application.Current.MainPage = new NavigationPage(new ListePage(Container));
        }

        public Command CommandEintragspeichern { get; }
        public Command CommandNächsteseite { get; }

    }
}
