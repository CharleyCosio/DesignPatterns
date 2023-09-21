using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.Builder
{
    public class PrepareDrink
    {
        public List<string> Ingredients = new List<string>();
        public int Milk;
        public int Water;
        public decimal Alcohol;

        public PrepareDrink()
        {
            
        }

        public string Result;
    }
}
