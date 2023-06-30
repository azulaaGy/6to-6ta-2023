using System;
using System.Threading.Tasks;

namespace ConsoleAsyncDemo
{
    static class Program
    {
        static void Main()

        {              //nombres de los tasks a esperar
            Task.WhenAll(primero(), segundo(), tercero()).Wait(); //whenAll hace que este task espere a todos los demás.
            Console.WriteLine("Todos los task completados :)");
        }

        //primer hilo
        static private async Task primero()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("iteración "+i+" del primer bucle");
            }
            await Task.Delay(1000);
        }

        //segundo hilo
        static private async Task segundo()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("iteración " + i + " del segundo bucle");
            }
            await Task.Delay(1000);
        }

        //tercer hilo
        static private async Task tercero()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("iteración " + i + " del tercer bucle");
            }
            await Task.Delay(1000);
        }
    }
}