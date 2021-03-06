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
            try
            {
                // Commands
                CommandEintragspeichern = new Command(Command1);
                CommandNächsteseite = new Command(Command2);
                CommandTutorial = new Command(Command3);
                ItemListe = new ObservableCollection<item>();
            }
            catch (Exception)
            {
                simplealert("Error", "Es ist ein Fehler aufgetreten!");
            }

        }
        /// <summary>
        /// Ctor falls man wieder auf die Seite verweisst
        /// </summary>
        /// <param name="temp"></param>
        public MainPageViewModel(ObservableCollection<item> temp)
        {
            try
            {
                CommandEintragspeichern = new Command(Command1);
                CommandNächsteseite = new Command(Command2);
                CommandTutorial = new Command(Command3);
                ItemListe = temp;
            }
            catch (Exception)
            {
                simplealert("!Error!", "Es ist ein Fehler aufgetreten!");
            }

        }

        /// <summary>
        /// Makes an simple Alert Box popping off the users Screen
        /// </summary>
        /// <param name="title">The Title of the Alert</param>
        /// <param name="text">The Text</param>
        public async void simplealert(string title, string text)
        {
            Application.Current.MainPage.DisplayAlert(title, text, "Weiter!");
        }


        private string name;
        /// <summary>
        /// Name of the item
        /// </summary>
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
        /// <summary>
        /// How much money the item values
        /// </summary>
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
        /// <summary>
        /// Needed for tests
        /// </summary>
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
            try
            {
                if (Name != "" && Convert.ToDouble(Betrag) > 0)
                {
                    ItemListe.Add(new item(Name, Convert.ToDouble(Betrag)));
                    simplealert("Aufgabe Erfolgreich", "Item abgegeben");
                    Betrag = "";
                    Name = "";
                }
                else
                {
                    simplealert("Warnung", "Du hast gar keinen Namen oder Betrag angegeben!");
                }
            }
            catch (Exception)
            {
                simplealert("Error", "Es ist ein Fehler aufgetreten!");
            }

        }

        /// <summary>
        /// 
        /// </summary>
        async void Command2()
        {
            try
            {
                Application.Current.MainPage = new NavigationPage(new ListePage(ItemListe));
            }
            catch (Exception)
            {
                simplealert("Error", "Es ist ein Fehler aufgetreten!");
            }
        }

        async void Command3()
        {
            try
            {
                simplealert("Tutorial", "Geben sie den Namen und den Preis des gesparten Objektes an. Klicken sie dannach auf Speichern. Um alle Einträge zu sehen drücken sie auf zu den Einträgen");
            }
            catch (Exception)
            {
                simplealert("Error", "Es ist ein Fehler aufgetreten!");
            }
        }

        /// <summary>
        /// Command to save a item
        /// </summary>
        public Command CommandEintragspeichern { get; }


        /// <summary>
        /// Command to change Pages
        /// </summary>
        public Command CommandNächsteseite { get; }


        /// <summary>
        /// Command to display Tutorial
        /// </summary>

        public Command CommandTutorial { get; }

















    }

}
