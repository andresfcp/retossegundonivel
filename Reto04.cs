/*
Escribe un programa que pida al usuario ingrese su animal favorito, si coloca ‘Tortuga’, 
‘tortuga’, ‘TORTUGA’ o cualquier otra variante de la palabra entonces mostrar en pantalla 
“También me gustan las tortugas”. En caso contrario mostrar el mensaje “Ese animal es 
genial, pero prefiero las tortugas”.
*/
using System;

namespace tortuga
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal;
            Console.WriteLine("Digite un animal:");
            animal= Console.ReadLine();
            
            
            if (animal.ToLower()=="tortuga")
            {
                Console.WriteLine("También me gustan las tortugas");
            }
            else
            {
                Console.Write("Ese animal es genial, pero prefiero las tortugas");
            }

        }
    }
}
