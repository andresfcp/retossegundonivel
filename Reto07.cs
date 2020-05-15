/*
Crearás un un script para el que el usuario indicará un número entre 1 y 6. 
Como respuesta se le brindará un mensaje según el número leido:
1 - “Hoy aprenderemos sobre prorgamación”
2 - “¿Qué tal tomar un curso de marketing digital?
3 - “Hoy es un gran día para comenzar a aprender de diseño”
4 - ¿Y si aprendemos algo de negocios online?
5 - “Veamos un par de clases sobre producción audiovisual”
6 - “Tal vez sea bueno desarrollar una habilidad blanda en Platzi”
En caso indicar un número distinto, pedir al usuario que ingrese uno en el rango válido.
*/

using System;

namespace reto07
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.WriteLine("Digite un numero");
                numero = int.Parse(Console.ReadLine());
            } while (numero > 6 || numero < 1);

            if (numero == 1)
            {
                Console.WriteLine("Hoy aprenderemos sobre programación");
            }
            else if (numero == 2)
            {
                Console.WriteLine("¿Qué tal tomar un curso de marketing digital?");
            }
            else if (numero == 3)
            {
                Console.WriteLine("Hoy es un gran día para comenzar a aprender de diseño");
            }
            else if (numero == 4)
            {
                Console.WriteLine("¿Y si aprendemos algo de negocios online?");
            }
            else if (numero == 5)
            {
                Console.WriteLine("Veamos un par de clases sobre producción audiovisual");
            }
            else if (numero == 6)
            {
                Console.WriteLine("Tal vez sea bueno desarrollar una habilidad blanda en Platzi");
            }
        }
    }
}
