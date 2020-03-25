using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Musica
{
    class Cancion 
    {
        public string genero { set; get; }
        public string artista { set; get; }
        public string album { set; get; }
        public string nombre { set; get; }



        /*public Cancion(string genero, string artista, string album, string nombre)
        {
            this.genero = genero;
            this.artista = artista;
            this.album = album;
            this.nombre = nombre;
        }
        */
        public string informacion()
        {

            return $"genero: {genero} \nartista: {artista} \nalbum: {album} \nnombre: {nombre} " ;
        }


    }

        
    
}
