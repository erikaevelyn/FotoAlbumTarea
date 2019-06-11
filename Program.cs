using System;

namespace FotoAlbumTarea
{
    class Program
    {
        static void Main(string[] args)
        {
            FotoAlbum albumChicoDefecto = new FotoAlbum();
            Console.WriteLine($"El album chico por defecto tiene {albumChicoDefecto.GetNumeroDePaginas()} paginas.");

            Console.WriteLine("Ingrese el numero de paginas que tendra el album: ");
            int paginas = Convert.ToInt32(Console.ReadLine());
            FotoAlbum albumChicoPersonalizado = new FotoAlbum(paginas);
            Console.WriteLine($"El album chico personalizado tiene {albumChicoPersonalizado.GetNumeroDePaginas()} paginas.");

            GranFotoAlbum albumGrande= new GranFotoAlbum();
            Console.WriteLine($"El album grande por defecto tiene {albumGrande.GetNumeroDePaginas()} paginas.");

            Console.ReadLine();
        }
    }
}
