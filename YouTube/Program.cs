using System;

namespace YouTube
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese fecha subida: ");
            string fecha = Console.ReadLine();

            DateTime fechaSubida = Convert.ToDateTime(fecha);

            //Informar objeto DateTime con formato de fecha con detalle
            Console.WriteLine(fechaSubida.ToLongDateString());

            Video clase = new Video(nombre, fechaSubida);

            clase.Informar();
        }
    }
}
