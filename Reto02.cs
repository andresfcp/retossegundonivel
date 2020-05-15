/*
Pide al usuario que indique 2 números: uno que servirá como límite y otro para comparar. Si el 
segundo número es menor al primero, mostrarás un mensaje diciendo “El número ‘x’ se encuentra
 en el rango, gracias” y en caso contrario dirá “El número ‘x’ excede el límite permitido”.
*/


using System;

namespace reto02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;
            Console.WriteLine("digite un número:");
            numero1=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite otro número:");
            numero2=int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("El número " + numero2 + " se encuentra  en el rango, gracias");
            }
            else
            {
                Console.WriteLine("El número "+ numero2 + " excede el límite permitido");
            }
        }
    }
}
