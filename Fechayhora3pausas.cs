using System;
using System.Threading;

namespace Fechayhora3pausas
{
    public class Program
    {
        public static void Main()
        {
            DateTime fecha = DateTime.Now;  // inicializamos la variable fecha, con la fecha actual.

            Console.WriteLine("Son las {0}: {1}:{2} ",fecha.Hour,fecha.Minute,fecha.Second);
            Console.WriteLine("Vamos a esperar 10 segundos .....");
            Thread.Sleep(10000);  // comando para hacer la pausa en 5 segundos
            fecha = DateTime.Now;  // actualizamos la fecha en Horas , minutos,segundos(en tiempo)
            Console.WriteLine("Ahora son las {0}: {1}:{2} ", fecha.Hour, fecha.Minute, fecha.Second);
            Console.WriteLine("Ahora vamos a esperar medio minuto....");
            Thread.Sleep(30000);
            fecha = DateTime.Now;
            Console.WriteLine("Ahora despues de medio minuto son {0}: {1}:{2}", fecha.Hour, fecha.Minute, fecha.Second);
            Console.WriteLine("hora de dormir byeeeeeeeee.....");
            Console.ReadKey();

        }
    }
}
