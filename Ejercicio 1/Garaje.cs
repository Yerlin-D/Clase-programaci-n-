using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Garaje
    {
        //Declaramos las propiedades 
        private Coche Coche;
        private string averia_asociada;
        private int atendidos = 0;

        public Garaje (Coche coche, string averia_asociada, int atendidos)
        {
            Coche1 = coche;
            this.Averia_asociada = averia_asociada;
            this.Atendidos = atendidos;
        }

        public string Averia_asociada { get => averia_asociada; set => averia_asociada = value; }
        public int Atendidos { get => atendidos; set => atendidos = value; }
        internal Coche Coche1 { get => Coche; set => Coche = value; }
    }

}

