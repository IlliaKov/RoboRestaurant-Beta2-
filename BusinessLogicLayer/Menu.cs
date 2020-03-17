using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Menu
    {
        public List<Dish> dishes = new List<Dish>();
        public List<Ingredients> ingredients = new List<Ingredients>();
        public IngredientsBasement Basement = new IngredientsBasement();
        public List<Menu> menuD = new List<Menu>();

        public void AddingDish()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MenuCon"].ConnectionString;

            dishes = new JsonSerialization<List<Dish>>(connectionString, null).Deserialize();
            //dishes = new JsonSerialization<List<Dish>>(@"C:\Users\Illia\Desktop\RoboRestaurant(Beta2)\BusinessLogicLayer\bin\Debug\aaaa.json", null).Deserialize();
        }
        public void AddSpec(Dish d)
        {
            dishes.Add(d);
        }
    }
   
}
