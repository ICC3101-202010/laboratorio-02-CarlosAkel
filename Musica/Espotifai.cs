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
        List<Cancion> songsList = new List<Cancion>();



        

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
                if (item.Tipo("genero") == cancion.Tipo("genero") & item.Tipo("album") == cancion.Tipo("album") & item.Tipo("artista") == cancion.Tipo("artista") & item.Tipo("nombre") == cancion.Tipo("nombre"))
                {
                    Console.WriteLine("Invalodio, elemento repetido");
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
                Console.WriteLine(item.Tipo("genero"));
                Console.WriteLine(item.Tipo("album"));
                Console.WriteLine(item.Tipo("artista"));
                Console.WriteLine(item.Tipo("nombre"));
            }
            /*Console.WriteLine(ListaMusica[0].genero);
            Console.WriteLine(ListaMusica[0].album);
            Console.WriteLine(ListaMusica.Count);*/


            }
        public List<Cancion> CancionesPorCriterio(String criterio, String valor)
        {
            //algo que borre la lista
            songsList.Clear();
            foreach (Cancion item in ListaMusica)
            {
                if (criterio == "genero" & valor == item.Tipo("genero"))
                {
                    songsList.Add(item);
                }
                else if (criterio == "album" & valor == item.Tipo("album"))
                {
                    songsList.Add(item);
                }
                else if (criterio == "artista" & valor == item.Tipo("artista"))
                {
                    songsList.Add(item);
                }
                else if (criterio == "nombre" & valor == item.Tipo("nombre"))
                {
                    songsList.Add(item);
                }

            }
            return songsList;


        }
    }
}
