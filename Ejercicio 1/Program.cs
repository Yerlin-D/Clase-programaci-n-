using Ejercicio_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

class Program
{ 
    static void Main(string[] args)
    {
       
        //Creación de coches
        Coche coche1 = new Coche("Ford" , "Fiesta Pequeño") ;
        Coche coche2 = new Coche("CHANGAN", "CS15 E - Pro");

        //Creacion Garaje 
        Console.Write("\n\nGaraje LA\n");
        Random r = new Random();
        Motor mt = new Motor (1800);
        Garaje mj = new Garaje();
        Console.WriteLine("Número de autos atendidos: " + mj.Númerodecochesaten);
        if (!mj.aceptarCoche(coche1, "Aire acondicionado"))
        {
            Console.WriteLine("El garaje posee un auto en reparación. ");
        }
        if (!mj.aceptarCoche(coche1, "Luces"))
        {
            Console.WriteLine("El garaje está lleno.");
        }
        mj.devolverCoche(coche1, "Aire acondicionado");
        mj.devolverCoche(coche1, "Luces");
        if (!mj.aceptarCoche(coche2, "Gomas"))
        {
            Console.WriteLine("El garaje posee un auto en reparación. ");
        }
        else
        {
            mj.devolverCoche(coche2, "Gomas");
        }
        if (!mj.aceptarCoche(coche2, "aceite"))
        {
            Console.WriteLine("El garaje posee un auto en reparación. ");
        }
        else
        {
            mj.devolverCoche(coche2, "aceite");
        }
        if (!mj.aceptarCoche(coche2, "aceite"))
        {
            Console.WriteLine("El garaje posee un auto en reparación. ");
        }
        else
        {
            mj.devolverCoche(coche2, "aceite");
        }
        Console.WriteLine("Número de autos atendidos: " + mj.Númerodecochesaten);
        coche1.acumularAveria(r.Next(500, 10000));
        Console.WriteLine(coche1.ToString());
        coche2.acumularAveria(r.Next(500, 10000));
        Console.WriteLine(coche2.ToString());
        Console.ReadKey();

    }






    public class Motor
    {
        private int litros_de_aceite;
        private int potencia;
        public Motor(int potencia)
        {
            this.Potencia = potencia;
        }
        public int Litros_de_aceite
        {
            get { return litros_de_aceite; }
            set { litros_de_aceite = value; }
        }
        public int Potencia
        {
            get { return potencia; }
            set { potencia = value; }
        }
    }
    public class coche
    {
        //Atributos
        private Motor motor;
        private string marca;
        private string modelo;
        private double precio_acumulado_averias;
        //Constructor con parámetros string "Marca" y "Modelo"
        public coche(string Marca, string Modelo)
        {
            marca1 = Marca;
            modelo1 = Modelo;
        }
        //Setter y Getter "Motor motor"
        public Motor Motor
        {
            get { return motor; }
            set { motor = value; }
        }
        //Setter y Getter "marca1"
        public string marca1
        {
            get { return marca; }
            set { marca = value; }
        }
        //Setter y Getter "modelo1"
        public string modelo1
        {
            get { return modelo; }
            set { modelo = value; }
        }
        //Setter y Getter "precio_acumulado_averias1"
        public double precio_acumulado_averias1
        {
            get { return precio_acumulado_averias; }
            set { precio_acumulado_averias = value; }
        }
        //Método acumularAveria
        public void acumularAveria(double montototal)
        {
            precio_acumulado_averias = precio_acumulado_averias + montototal;
        }
    }

    public class Garaje
    {
        private coche Coche;
        private string averíaAsociada;
        private int númerodecochesaten = 0;
        public int Númerodecochesaten
        {
            get => númerodecochesaten;
            set => númerodecochesaten = value;
        }
        public string AveríaAsociada
        {
            get => averíaAsociada;
            set => averíaAsociada = value;
        }
        public coche coche1
        {
            get => Coche;
            set => Coche = value;
        }
        public bool aceptarCoche(coche Coche, string averíaAsociada)
        {
            if (Coche != null)
            {
                return false;
            }
            else
            {
                coche1 = Coche;
                AveríaAsociada = averíaAsociada;
                if (Equals(AveríaAsociada, "aceite"))
                {
                    Motor mt = new Motor(1800);
                    Console.WriteLine("Litros de aceite:");
                    mt.Litros_de_aceite = mt.Litros_de_aceite + (10);
                    Console.WriteLine(mt.Litros_de_aceite);
                }
                else
                {
                    Motor mt = new Motor(1800);
                    mt.Litros_de_aceite = mt.Litros_de_aceite;
                    Console.WriteLine(mt.ToString());
                }
                númerodecochesaten++;
                return true;
            }
        }
        public void devolverCoche(coche coche, string averíaAsociada)
        {
            Coche = null;
            averíaAsociada = null;
        }
        public override string ToString()
        {
            return "Avería: " + AveríaAsociada + "\n";
        }

        internal bool aceptarCoche(Coche coche1, string v)
        {
            throw new NotImplementedException();
        }

        internal void devolverCoche(Coche coche1, string v)
        {
            throw new NotImplementedException();
        }

    }



}
