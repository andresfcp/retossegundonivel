/*
Crea un programa que pregunte al usuario si está lloviendo, en caso de responder “sí” pregunta
si está haciendo mucho viento y si responde “sí” nuevamente muestra un mensaje indicando que
 hace mucho viento para salir con una sombrilla. En caso contrario, anima al usuario a que 
 lleve una sombrilla. Para el caso de responder “no” en la primer pregunta, entonces solo desea 
 un bonito día.
Considera que las respuestas pueden pasarse a minúsculas para evitar posibles errores.
*/


using System;

namespace clima
{
    class Program
    {
        static void Main(string[] args)
        {
            string pregunta;

            Console.WriteLine("Está lloviendo?");
            pregunta=Console.ReadLine();

            if (pregunta.ToLower() == "si")
            {
                Console.WriteLine("Está haciendo mucho viento?");
                pregunta=Console.ReadLine();
                if (pregunta.ToLower() == "si")
                {
                    Console.WriteLine("hace mucho viento para salir con una sombrilla");
                }
                else
                {
                    Console.WriteLine("Deberias salir con una sombrilla");
                }
            }
            else
            {
                Console.WriteLine("Que tengas un buen día.");
            }


        }
    }
}
