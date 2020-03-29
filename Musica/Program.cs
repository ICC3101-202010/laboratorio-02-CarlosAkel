using System;


namespace Musica
{
    class Program
    {
        static void Main(string[] args)
        {
            Cancion spt = new Cancion("uno","dos","tres","cuato");
            Cancion dos = new Cancion("uno", "dos", "tres", "cuato");
            Espotifai esp = new Espotifai();
            /*spt.genero = "uno";
            spt.album = "dos";
            spt.artista = "tres";
            spt.nombre = "cuatro";*/
            Console.WriteLine(spt.informacion());

            /*Console.WriteLine(spt);
            Console.WriteLine(esp.AddSong(spt));
            Console.WriteLine(esp.AddSong(dos));
            esp.ShowSongs();*/
            Console.WriteLine(esp.AddSong(spt));
            Console.WriteLine(esp.AddSong(dos));
            Console.WriteLine("Deseas iniciar secion? (yes/no)");
            if(Console.ReadLine() == "yes")
            {
                Console.WriteLine("Bienvenido");
                Console.WriteLine("Que quieres hacer?");

                while (true)
                {
                    Console.WriteLine("Ver canciones disponibles[0]--Agregar una Cancion[1]--Ver Canciones por Criterio[2]--Salir del Programa[3]");
                    int Request = Int16.Parse(Console.ReadLine());
                    if (Request == 0)
                    {
                        esp.ShowSongs();
                    }
                    else if (Request == 1)
                    {
                        Console.WriteLine("genero");
                        string a = Console.ReadLine();
                        Console.WriteLine("artista");
                        string b = Console.ReadLine();
                        Console.WriteLine("album");
                        string c = Console.ReadLine();
                        Console.WriteLine("nombre");
                        string d = Console.ReadLine();
                        Cancion add = new Cancion(a, b, c, d);
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
                            Console.WriteLine(item.Tipo("genero"));
                            Console.WriteLine(item.Tipo("album"));
                            Console.WriteLine(item.Tipo("artista"));
                            Console.WriteLine(item.Tipo("nombre"));
                            Console.WriteLine(" ");
                        }
                    }
                    else if (Request == 3)
                    {
                        System.Environment.Exit(0);
                    }
                }
            }








        }
    }
}
