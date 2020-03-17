using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    interface IDish
    {
        int Weight { get; set; }
        
        int TimeOfPrep { get; set; }
        List<Ingredients> Ingredients {get; set; }

        int Price { get; set; }
    }
}
