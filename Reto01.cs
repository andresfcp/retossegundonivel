/*
Escribe un programa que pida al usuario 2 números, mostrando como salida cuál es el 
número mayor y la diferencia de uno respecto al otro. En caso de que los números sean 
iguales, mostrarlo también en pantalla.
*/

using System;

namespace numeromayor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, diferencia;
            Console.WriteLine("Digite un número:");
            
            numero1=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite un número:");
            numero2=int.Parse(Console.ReadLine());
            if (numero1>numero2)
            {
                Console.WriteLine(numero1 + " es mayor que "+ numero2);
                diferencia=numero1-numero2;
                Console.WriteLine("la diferencia entre los dos es de "+diferencia);
            }
            else if (numero2>numero1)
            {
                Console.WriteLine(numero2 + " es mayor que "+ numero1);
                diferencia=numero2-numero1;
                Console.WriteLine("la diferencia entre los dos es de "+diferencia);
            }
            else
            {
                Console.WriteLine("Los dos números son iguales");
            }


        }
    }
}
