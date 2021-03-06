﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//delete it/ and silku udalit
//some issues with spec ordering 
namespace BusinessLogicLayer
{
    public class SpecTimeOrder : ISpecTimeOrder
    {
        IngredientsBasement Base = new IngredientsBasement();
        Menu menuDish = new Menu();


        static DateTime currentTime = DateTime.Now;
        DateTime antiBoilingTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 20, 30, 00);
        DateTime closingTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 22, 00, 00);
        public SpecTimeOrder()
        {
            menuDish.AddingDish();
        }
        public void SpecTime()
        {
            if (currentTime >= antiBoilingTime)
            {
                string ig = "";
                foreach (var dish in menuDish.dishes)
                {
                    bool DishIngT = true;
                    string ig1 = "";
                    foreach (var ingr in dish.Ingredients)
                    {
                        if (ingr.TempChange == false && DishIngT == true)
                        {
                            ig1 += dish.dName + " ";
                        }
                        else
                        {
                            DishIngT = false;
                            ig1 = "";
                            break;
                        }
                    }
                    ig += ig1;

                }
                MessageBox.Show("You can only choose these dishes: " + ig);
            }
            else if (currentTime >= closingTime)
            {
                throw new Exception("Sorry, but we are closed!");
            }
        }
    }
}
