/*
Pide al usuario que ingrese su edad y mostrarás un mensaje correspondiente si esta coincide con las siguientes condiciones:
Más de 30 años: Nunca es tarde para aprender ¿Qué curso tomaremos?
Entre 29 y 18 años: Es un momento excelente para impulsar tu carrera.
Menos de 18 años: ¿Sabes hacia dónde dirigir tu futuro? Seguro puedo ayudarte.
*/


using System;

namespace edadpermitida
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Digite su edad");
            edad=int.Parse(Console.ReadLine());
            if (edad >=30 )
            {
                Console.WriteLine("Nunca es tarde para aprender ¿Qué curso tomaremos?");
            }
            else if (edad < 30 && edad >= 18)
            {
                Console.WriteLine("Es un momento excelente para impulsar tu carrera.");
            }
            else
            {
                Console.WriteLine("¿Sabes hacia dónde dirigir tu futuro? Seguro puedo ayudarte.");
            }


        }
    }
}
