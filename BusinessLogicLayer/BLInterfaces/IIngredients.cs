using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    interface IIngredients
    {
        string Iname { get; set; }
        int Quantity { get; set; }
        bool TempChange { get; set; }
    }
}
