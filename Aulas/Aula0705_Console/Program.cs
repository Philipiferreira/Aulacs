using System;

namespace Aula0705_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            Console.WriteLine("Hello World");
           
            Console.WriteLine("i:", + i);
            

            if (Console.CapsLock)
                Console.WriteLine("CapsLock Ativado");
            else
                Console.WriteLine("Capslock Desativado");

            Console.ReadKey();
        }
    }
}
