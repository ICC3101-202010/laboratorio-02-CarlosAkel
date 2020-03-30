using System;
using System.Collections.Generic;
using System.Text;

namespace Musica
{
    class PlayList 
    {
        private string criterio { get; set; }
        private string valorCriterio { get; set; }
        private string nombrePlaylist { get; set; }

        List<PlayList> ListaRep = new List<PlayList>();


        public string ShowSongs2()
        {
            foreach (PlayList item in ListaRep)
            {

                return item.Datos("nombrePlaylist");

            }
            return "-------";
        }
        public PlayList(string criterio, string valorCriterio, string nombrePlaylist)
        {
            this.criterio = criterio;
            this.valorCriterio = valorCriterio;
            this.nombrePlaylist = nombrePlaylist;
        }


     

        public string Datos(string datos)
        {
            if (datos == "criterio")
            {
                return criterio;
            }
            else if (datos == "valorCriterio")
            {
                return valorCriterio;
            }
            else if (datos == "nombrePlaylist")
            {
                return nombrePlaylist;
            }
            return "0";
        }
        public List<PlayList> Listas()
        {
            return ListaRep;
        }
        public bool añadir(PlayList cosa)
        {
            ListaRep.Add(cosa);
            return true;
        }
    }

    
}
