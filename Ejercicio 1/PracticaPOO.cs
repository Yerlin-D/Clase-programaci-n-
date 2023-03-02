using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{

    class Program
    {
        private int NuevoCoche;
        private Coche[] _coche;
        private int _numCoche;



        //Metodo para añadir coche
        public void añadirchoche(Coche a)
        {
            if (a != null && _numCoche < _coche.Length)
            {
                _coche[_numCoche++] = a;
            }
            for (int i = 0; i < _coche.Length; i++)
            {
                Console.WriteLine(_coche[i].ToString());
            }
        }

        //Metodo para eliminar coche 
        public void eliminarcoche(Coche a)
        {
            if (a != null && _numCoche != 0)
            {
                int posicion = -1;
                for (int i = 0; i < _numCoche ; i++)
                {
                    if (a == _coche[i])
                    {
                        posicion = i;
                    }
                }
                if (posicion == -1)
                {
                    Console.WriteLine("No existe ningun coche");
                }
                else
                {
                    _coche[posicion] = null;
                    for (int i = posicion; i < _numCoche - 1; i++)
                    {
                        _coche[i] = _coche[i + 1];
                    }
                    _numCoche--;
                }

            }
        }

    }
}
