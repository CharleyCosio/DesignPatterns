using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.Strategy
{
    public class BiciStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Soy una Bici");
        }
    }
}
