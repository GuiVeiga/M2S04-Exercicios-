using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class CarroProtected
    {
        public CarroProtected(int rodas, string motor)
        {
            Rodas = rodas;
            Motor = motor;
        }

        protected int Rodas { get; set; }

        protected string Motor { get; set; }
    }
}
