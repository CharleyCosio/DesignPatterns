using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.Singleton
{
    public class Singleton
    {
        //UN UNICO OBJETO EN TODA LA APLICACION
        private readonly static Singleton _instance = new Singleton();

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }


        private Singleton() { }
    }
}
