﻿using System;
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
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="temp">Give the Itemlist</param>
        public ListePageViewModel(ObservableCollection<item> temp)
        {
            try
            {
                Commandlisteleeren = new Command(Command3);
                Commandspeichern = new Command(Command4);
                CommandzurückHauptseite = new Command(Command5);
                ItemListe = temp;
            }
            catch (Exception)
            {

                simplealert("Error", "Es ist ein Fehler aufgetreten!");
            }

        }

        /// <summary>
        /// Make an Simple Alert PopUp with Standard Button Weiter!
        /// </summary>
        /// <param name="title">Set the Title of the Alert</param>
        /// <param name="text">Set the text displayed in the Alert</param>
        public async void simplealert(string title, string text)
        {
            Application.Current.MainPage.DisplayAlert(title, text, "Weiter!");
        }

        async void Command3()
        {
            try
            {
                ItemListe.Clear();
                simplealert("Aufgabe Erfolgreich", "Liste wurde geleert!");
            }
            catch (Exception)
            {
                simplealert("Error", "Es ist ein Fehler aufgetreten!");
            }
        }

        /// <summary>
        ///  
        /// </summary>
        async void Command4()
        {
            try
            {

            }
            catch (Exception)
            {
                simplealert("Error", "Es ist ein Fehler aufgetreten!");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        async void Command5()
        {
            try
            {
                Application.Current.MainPage = new NavigationPage(new MainPage(ItemListe));
            }
            catch (Exception)
            {
                simplealert("Error", "Es ist ein Fehler aufgetreten!");
            }

        }

        async void Command6()
        {
            try
            {

            }
            catch (Exception)
            {
                simplealert("Error", "Es ist ein Fehler aufgetren!");
            }
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

        /// <summary>
        /// Deletes the item which is currently selected in the ListView
        /// </summary>
        public Command CommandAusgewähltesItemLöschen { get; set; }



    }
}
