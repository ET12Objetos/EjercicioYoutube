using System;

namespace YouTube
{
    public class Video
    {
        public string nombre;

        public int duracion;

        public int cantVisualizaciones;

        public int cantLikes;

        public int cantDisLikes;

        public DateTime fechaSubida { get; set; }

        public Video(string nombre, DateTime fechaSubida)
        {
            //Instancio objeto de numero aleatorio
            Random numero = new Random();

            this.nombre = nombre;

            this.duracion = 200 + numero.Next(300);

            this.cantVisualizaciones = numero.Next(200, 500);

            this.cantLikes = numero.Next(200, 500);

            this.cantDisLikes = numero.Next(200, 500);

            this.fechaSubida = fechaSubida;
        }

        public void Informar()
        {
            Console.WriteLine($"Nombre: {nombre}, Duracion: {duracion}, Fecha Subida: {fechaSubida.ToShortDateString()}");
            Console.WriteLine($"Cantidad");
            Console.WriteLine($"- Visualizaciones: {cantVisualizaciones}");
            Console.WriteLine($"- Likes: {cantLikes}");
            Console.WriteLine($"- DisLikes: {cantDisLikes}");
        }
    }
}