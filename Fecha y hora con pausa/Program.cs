using System;
using System.Threading;

namespace Fecha_y_hora_con_pausa
{
    public class Program
    {
        public static void Main()
        {
            DateTime fecha = DateTime.Now;  // inicializamos la variable fecha, con la fecha actual.

            Console.WriteLine("Son las {0}: {1}:{2} ",fecha.Hour,fecha.Minute,fecha.Second);
            Console.WriteLine("Vamos a esperar 5 segundos .....");
            Thread.Sleep(5000);  // comando para hacer la pausa en 5 segundos
            fecha = DateTime.Now;  // actualizamos la fecha en Horas , minutos,segundos(en tiempo)
            Console.WriteLine("Ahora son las {0}: {1}:{2} ", fecha.Hour, fecha.Minute, fecha.Second);

            Console.ReadKey();

        }
    }
}
