using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12
{
    public class CafeteraSingleton
    {
        private static CafeteraSingleton instance;//statico la variable es de esta clase

        private CafeteraSingleton()
        {

        }

        public static CafeteraSingleton GetInstance()
        {
            if(instance == null)//La primeravez que se llame es nulo creamos la instancia del objeto
            {
                instance = new CafeteraSingleton();
            }
            return instance;
        }

    }
}
