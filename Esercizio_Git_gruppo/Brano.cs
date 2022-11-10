using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Git_gruppo
{
    internal class Brano
    {
        
        //Belletti Lorenzo ( Placuzzi Nicola , Alberto Vincenzi
       
        internal string Titolo { get; private set; }
        internal string Nome { get; private set; }
        internal double Durata { get; private set; }


        public Brano(string Titolo, string Nome, double Durata)
        {
            this.Titolo = Titolo;
            this.Nome = Nome;
            this.Durata = Durata;
        }


        internal string toString()
        {
            return Titolo + " " + Nome + " " + Durata;
        }


        bool durataInferiore = false;
        internal bool shortSong(double durata)
        {
            if (durata < this.Durata)
                durataInferiore = true;          
           
            return durataInferiore;
        }
    }
}
