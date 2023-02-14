using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //Creación de función ROT13
    static class rot13
    {
        public static string descifrar(string newfrase)
        {
            char[] arreglo = newfrase.ToCharArray();
            for (int i = 0; i < arreglo.Length; i++)
            {
                int x = (int)arreglo[i];
                if (x >= 'A' && x <= 'Z')
                {
                    if (x > 'M')
                    {
                        x -= 13;
                    }
                    else
                    {
                        x += 13;
                    }
                }
                arreglo[i] = (char)x;
            }
            return new string(arreglo);
        }
    }

    static void Main(string[] args)
    {
        string frase;
        Console.WriteLine("Digite la palabra o frase que desea descifrar: ");
        frase = Console.ReadLine();

        //Llamamos a la función ROT13, creada al inicio del codigo
        frase = rot13.descifrar(frase);
        Console.WriteLine("El texto descifrado: ");
        Console.WriteLine(frase);

    }

}
