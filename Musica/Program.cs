using System;


namespace Musica
{
    class Program
    {
        static void Main(string[] args)
        {
            Cancion spt = new Cancion("Funk Rock","Bradio", "Diamond Pops", "Golden Liar");
            Cancion dos = new Cancion("Kpop", "IKON", "New Kids: Continue ", "Killing Me");
            Espotifai esp = new Espotifai();

            Console.WriteLine(spt.informacion());

            Console.WriteLine(esp.AddSong(spt));
            Console.WriteLine(esp.AddSong(dos));
            Console.WriteLine("¿Deseas iniciar secion? (yes/no)");
            if(Console.ReadLine() == "yes")
            {
                Console.WriteLine("Bienvenido");
                Console.WriteLine("¿Que quieres hacer?");

                while (true)
                {
                    Console.WriteLine("Ver canciones disponibles[0]--Agregar una Cancion[1]--Ver Canciones por Criterio[2]--Crear PlayList[3]--MostrarPlayList[4]--Salir del Programa[5]");
                    int Request = Int32.Parse(Console.ReadLine());
                    if (Request == 0)
                    {
                        esp.ShowSongs();
                    }
                    else if (Request == 1)
                    {
                        Console.WriteLine("genero");
                        string a = Console.ReadLine();
                        Console.WriteLine("artista");
                        string c = Console.ReadLine();
                        Console.WriteLine("album");
                        string b = Console.ReadLine();
                        Console.WriteLine("nombre");
                        string d = Console.ReadLine();
                        Cancion add = new Cancion(a, c, b, d);
                        Console.WriteLine(esp.AddSong(add));
                    }
                    else if (Request == 2)
                    {
                        Console.WriteLine("Coloque el criterio");
                        string e = Console.ReadLine();
                        Console.WriteLine("Coloque el valor");
                        string f = Console.ReadLine();
                        Console.WriteLine("Estos son los que se encuentran disponilbes");
                        foreach (Cancion item in esp.CancionesPorCriterio(e, f))
                        {
                            Console.WriteLine(item.informacion());
                            Console.WriteLine(" ");
                        }
                    }
                    else if(Request == 3)
                    {
                        Console.WriteLine("Coloque el criterio");
                        string g = Console.ReadLine();
                        Console.WriteLine("Coloque el valor del criterio");
                        string h = Console.ReadLine();
                        Console.WriteLine("Coloque el nombre de su playlist");
                        string i = Console.ReadLine();
                        Console.WriteLine(esp.GenerarPlaylist(g,h,i));

                    }
                    else if(Request == 4)
                    {
                        Console.WriteLine(esp.VerMisPlaylists());
                    }
                    else if (Request == 5)
                    {
                        Console.WriteLine("Hasta luego que tenga buen día");
                        System.Environment.Exit(0);
                    }
                }
            }








        }
    }
}
