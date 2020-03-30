using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;



namespace Musica
{
    class Espotifai
    {

        List<Cancion> ListaMusica = new List<Cancion>();
        List<Cancion> songsList = new List<Cancion>();
        List<Cancion> Play = new List<Cancion>();
        List<string> myStrings = new List<string>();




        public bool AddSong(Cancion cancion)
        {

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

        }
        public void ShowSongs()
        {
            foreach (Cancion item in ListaMusica)
            {
                Console.WriteLine(item.informacion());
                Console.WriteLine("-------");
            }


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
        public bool GenerarPlaylist(String criterio, String valorCriterio, String nombrePlaylist)
        {
            if(criterio == "genero" || criterio == "album" || criterio == "artista" || criterio == "nombre")
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("No se pudo ejecutar, intentelo denuevo");
                return false;
            }

            PlayList uno = new PlayList(criterio, valorCriterio, nombrePlaylist);
                if (uno.Listas().Contains(uno))
                {
                Console.WriteLine("No se pudo ejecutar, intentelo denuevo");
                return false;
                }
            uno.añadir(uno);
            Console.WriteLine(uno.Listas()[0].Datos("nombrePlaylist"));
            //myStrings.Clear();//revisar
            myStrings.Add(uno.ShowSongs2());




            foreach (Cancion item2 in ListaMusica)
            {
                if (item2.Tipo("genero") == valorCriterio)
                {
                    Play.Add(item2);
                    Console.WriteLine("si");
                    return true;
                }
                else if (item2.Tipo("album") == valorCriterio)
                {
                    Play.Add(item2);
                    return true;
                }
                else if (item2.Tipo("artista") == valorCriterio)
                {
                    Play.Add(item2);
                    return true;
                }
                else if (item2.Tipo("nombre") == valorCriterio)
                {
                    Play.Add(item2);
                    return true;
                }
            }
            Console.WriteLine("No se pudo ejecutar, intentelo denuevo");
            return false;
        }
        public String VerMisPlaylists()
        {
            int i = 0;
            PlayList uno = new PlayList("ha", "ha", "ha");
            foreach (Cancion item in Play)
            {
                Console.WriteLine(myStrings[i]);
                Console.WriteLine(item.Tipo("genero"));
                Console.WriteLine(item.Tipo("album"));
                Console.WriteLine(item.Tipo("artista"));
                Console.WriteLine(item.Tipo("nombre"));
                Console.WriteLine("-------");
                i++;
            }
            return " ";
        }

    }
}
