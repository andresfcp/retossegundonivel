/*
Nuevamente pide a tu usuario que indique 3 números: un límite superior, un límite inferior 
y uno de comparación. Si el número de comparación se encuentra entre los 2 primeros, 
comunicarlo en pantalla. En caso estar por debajo del límite inferior o por arriba del
 límite superior, también mostrarlo en pantalla.
*/


using System;

namespace reto03
{
    class Program
    {
        static void Main(string[] args)
        {
            int limiteSup, limiteInf, numero;
            Console.WriteLine("Digite el 1er número:");
            limiteInf=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el 2do número:");
            limiteSup=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite 3er número:");
            numero=int.Parse(Console.ReadLine());

            if (numero < limiteSup && numero > limiteInf)
            {
                Console.WriteLine("El número " + numero + " se encuentra  en el rango, gracias");
            }
            else
            {
                if (numero > limiteSup)
                {
                    Console.WriteLine("El número "+ numero + " excede el límite superior permitido");
                }
                else
                {
                    Console.WriteLine("El número "+ numero + " es menor que el límite Inferior permitido");
                }
                
            }
        }
    }
}
