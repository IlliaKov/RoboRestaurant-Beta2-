using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
     [DataContract]
     public class Dish : IDish
    {
        private int weight;
        private int timeofprep;
        private List<Ingredients> ingredients = new List<Ingredients>();
        private int price;
        public dishName dName;

        public enum dishName
        {
            Borsch,
            Green_Borsch,
            Vegetable_Soup,
            Strawberry_Jelly,
            Banana_Juice
        }
        [DataMember]
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        [DataMember]
        public int TimeOfPrep
        {
            get { return timeofprep; }
            set { timeofprep = value; }
        }
        [DataMember]
        public List<Ingredients> Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }
        [DataMember]
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public Dish(dishName dname, int weight, int timeofprep, List<Ingredients> ingred, int price)
        {

            dName = dname;
            Weight = weight;
            TimeOfPrep = timeofprep;
            Ingredients = ingred;
            Price = price;


        }

    }
}

