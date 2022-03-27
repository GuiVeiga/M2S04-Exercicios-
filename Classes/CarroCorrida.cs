using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class CarroCorrida: CarroProtected
    {
        public CarroCorrida(string modalidade, int rodas, string motor) : base(rodas, motor)
        {
            Modalidade = modalidade;
        }

        public string Modalidade { get; set; }


    }
}
