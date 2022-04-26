using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace SaveUp.ViewModel
{
    class ListePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Datacontainer Container = new Datacontainer();
        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ListePageViewModel()
        {
            // Commands
            Commandlisteleeren = new Command(Command1);
            Commandspeichern = new Command(Command2);
            CommandzurückHauptseite = new Command(Command3);
            
        }



        // Commands

        async void Command1()
        {
            Container.itemliste.Clear();
        }

        async void Command2()
        {

        }

        async void Command3()
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());

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
