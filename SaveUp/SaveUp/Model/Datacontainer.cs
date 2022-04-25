using System;
using System.Collections.Generic;
using System.Text;

namespace SaveUp
{

    /// <summary>
    /// This Class is for all the important Data in this Programm, to have it alot easier while transfer to other Pages all the Data gets Saved here
    /// </summary>
    public class Datacontainer
    {
        /// <summary>
        /// List for all the items
        /// </summary>
        public List<item> itemliste { get; set; }


        public Datacontainer()
        {
            itemliste = new List<item>();
        }

    }

}
