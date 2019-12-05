using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscManager
{
    class Disc
    {
        public string Autor { get; set; }
        public string Periodo { get; set; }
        public string Obra1 { get; set; }
        public string Obra2 { get; set; }
        public string Subobra { get; set; }
        public string Subobra2 { get; set; }
        public double Duracion { get; set; }
        public string Instrum { get; set; }
        public string Interpte { get; set; }
        public string Director { get; set; }
        public string Orquesta { get; set; }
        public string Coro { get; set; }
        public string DiscNum { get; set; }
        public string FabricNum { get; set; }
        public int CintaNum { get; set; }
        public string Coment { get; set; }
        public int Numero { get; set; }

        public Disc(string autor, string periodo, string obra1, string obra2, string subobra, string subobra2, double duracion, string instrum, string interpte, string director, string orquesta, string coro, string discNum, string fabricNum, int cintaNum, string coment, int numero)
        {
            Autor = autor;
            Periodo = periodo;
            Obra1 = obra1;
            Obra2 = obra2;
            Subobra = subobra;
            Subobra2 = subobra2;
            Duracion = duracion;
            Instrum = instrum;
            Interpte = interpte;
            Director = director;
            Orquesta = orquesta;
            Coro = coro;
            DiscNum = discNum;
            FabricNum = fabricNum;
            CintaNum = cintaNum;
            Coment = coment;
            Numero = numero;
        }

        public override string ToString()
        {
            return Autor + " - " + Periodo + " - " + Obra1 + " - " + Obra2 + " - " + Subobra + " - " + Subobra2 + " - " + Duracion + " - " + Instrum + " - " + Interpte + " - " + Director + " - " + Orquesta + " - " + Coro + " - " + DiscNum + " - " + FabricNum + " - " + CintaNum + " - " + Coment + " - " + Numero;
        }
    }
}
