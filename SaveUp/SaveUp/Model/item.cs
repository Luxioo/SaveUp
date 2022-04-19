using System;
using System.Collections.Generic;
using System.Text;

namespace SaveUp
{
    public class item
    {



        private string myVar;

        /// <summary>
        /// Name des items
        /// </summary>
        public string name
        {
            get { return myVar; }
            set { myVar = value; }
        }

        private double x;
        /// <summary>
        /// gesparter Geldwert durch das Item
        /// </summary>
        public double betrag
        {
            get { return x; }
            set { x = value; }
        }


        private DateTime y;

        public DateTime uhrzeit
        {
            get { return y; }
            set { y = value; }
        }


        public item()
        {

        }


        public item(string namedesproduktes, double gesparterbetrag)
        {
            name = namedesproduktes;

            betrag = gesparterbetrag;

            uhrzeit = DateTime.Now;
        }


    }
}
