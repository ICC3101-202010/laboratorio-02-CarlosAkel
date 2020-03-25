using System;


namespace Musica
{
    class Program
    {
        static void Main(string[] args)
        {
            Cancion spt = new Cancion();
            Cancion dos = new Cancion();
            Espotifai esp = new Espotifai();
            spt.genero = "uno";
            spt.album = "dos";
            spt.artista = "tres";
            spt.nombre = "cuatro";
            dos.genero = "uno";
            dos.album = "dos";
            dos.artista = "tres";
            dos.nombre = "cuatro";
            Console.WriteLine(spt.informacion());
            /*Console.WriteLine(spt);
            Console.WriteLine(esp.AddSong(spt));
            Console.WriteLine(esp.AddSong(dos));
            esp.ShowSongs();*/
            Console.WriteLine(esp.AddSong(spt));
            Console.WriteLine(esp.AddSong(dos));
            esp.ShowSongs();
            






        }
    }
}
