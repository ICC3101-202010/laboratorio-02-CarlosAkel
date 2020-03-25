using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;



namespace Musica
{
    class Espotifai 
    {
        //public string song { get; set; }
        /*public List<string> Rep { get; set; }*/
        List<Cancion> ListaMusica = new List<Cancion>();
        public string uwu { get; set; }

        

        public bool  AddSong(Cancion cancion)
        {
            //List<Espotifai> ListaMusica = new List<Espotifai>();
            /* Console.WriteLine("genero");
             cancion.genero = Console.ReadLine();
             Console.WriteLine("artista");
             cancion.artista = Console.ReadLine();
             Console.WriteLine("album");
             cancion.album = Console.ReadLine();
             Console.WriteLine("nombre");
             cancion.nombre = Console.ReadLine();*/
            foreach (Cancion item in ListaMusica)
            {
                if (item.genero == cancion.genero & item.album == cancion.album & item.artista == cancion.artista & item.nombre == cancion.nombre)
                {
                    return false;
                }

            }
            ListaMusica.Add(cancion);
            return true;
                /*if (ListaMusica.Contains(cancion))
            {
                return false;
            }
            else
            {
                ListaMusica.Add(cancion);
                return true;
            }*/



            //ListaMusica.Add(new Espotifai());

            /*foreach (var author in ListaMusica)
            {
                Console.WriteLine("datos",cancion.genero,cancion.artista,cancion.album,cancion.nombre);
            }
            return true;*/

        }
        public void ShowSongs()
        {
            foreach(Cancion item in ListaMusica)
            {
                Console.WriteLine(item.genero);
                Console.WriteLine(item.artista);
                Console.WriteLine(item.album);
                Console.WriteLine(item.nombre);
            }
            /*Console.WriteLine(ListaMusica[0].genero);
            Console.WriteLine(ListaMusica[0].album);
            Console.WriteLine(ListaMusica.Count);*/




        }
    }
}
