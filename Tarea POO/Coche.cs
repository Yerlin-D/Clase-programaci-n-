using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Coche
    {
        //Declaramos las propiedades 

        private int motor;
        private string marca;
        private string modelo;
        private double averias;



        // Colocamos el constructor para inicializar los objetos creados 
        public Coche(string marca, string modelo)
        {
            this.Marca = marca;
            this.Modelo = modelo;


        }

        // Colocamos los get / set 
        public int Motor { get => motor; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public double Averias { get => averias; }


        //Mostrar la información del objeto 
        public override string ToString()
        {
            return "Marca:" + marca;
        }

        internal void acumularAveria(int v)
        {
            throw new NotImplementedException();
        }
    }
}
