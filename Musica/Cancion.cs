using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Musica
{
    class Cancion 
    {
        private string genero { set; get; }
        private string artista { set; get; }
        private string album { set; get; }
        private string nombre { set; get; }



        public Cancion(string genero, string artista, string album, string nombre)
        {
            this.genero = genero;
            this.artista = artista;
            this.album = album;
            this.nombre = nombre;
        }
        
        public string Tipo(string tipo)
        {
            if(tipo == "genero")
            {
                return genero;
            }
            else if(tipo == "album")
            {
                return album;
            }
            else if (tipo == "artista")
            {
                return artista; 
            }
            else if (tipo == "nombre")
            {
                return nombre;
            }
            return "0";
        }
        public string informacion()
        {

            return $"genero: {genero} \nartista: {artista} \nalbum: {album} \nnombre: {nombre} " ;
        }


    }

        
    
}
