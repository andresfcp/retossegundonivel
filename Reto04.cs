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
