using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.Strategy
{
    public class MotoStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Soy una motocicleta");
        }
    }
}
