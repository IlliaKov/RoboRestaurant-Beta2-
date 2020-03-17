//using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public interface IOrdering 
    {
        void MakeOrder(Dish.dishName DM);
    }
}
