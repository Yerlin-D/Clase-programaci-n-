using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Motor
    {
        //Declaramos las propiedades 

        private int litros_de_aceite;
        private int potencia;

        // Colocamos el constructor para inicializar los objetos creados 
        public Motor(int litros_de_aceite, int potencia)
        {
            this.Litros_de_aceite = litros_de_aceite;
            this.Potencia = potencia;
        }

        // Colocamos los get / set 
        public int Litros_de_aceite { get => litros_de_aceite; set => litros_de_aceite = value; }
        public int Potencia { get => potencia; set => potencia = value; }
    }
     

}
