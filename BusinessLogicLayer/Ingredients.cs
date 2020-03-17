using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    [DataContract]
   public class Ingredients : IIngredients
    {
        private string iname;
        private int quantity;
        private bool tempChange;

        [DataMember]
        public string Iname
        {
            get { return iname; }
            set { iname = value; }
        }
        [DataMember]
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        [DataMember]
        public bool TempChange
        {
            get { return tempChange; }
            set { tempChange = value; }
        }

        public Ingredients(string iname, int quantity, bool tempChange)
        {
            Iname = iname;
            Quantity = quantity;
            TempChange = tempChange;

            if (Quantity < 1) throw new Exception("You can't cook with current amount of ingredients");
        }
    }
}
