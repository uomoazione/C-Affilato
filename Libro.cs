using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace programMain
{
    class Libro : Prodotto
    {
        private int _numpagine;
        private string _autore;
        private string _genere;

        public override double Costo { get; set; }
        public override string ID { get; set; }
        public override int Quantita { get; set; }
        public override string Nome { get; set; }
        public int NumPagine { get; set; }
        public string Autore { get; set; }
        public string Genere { get; set; }

        public Libro(int numpagine, string autore, string genere, double costo, string id, int quantita, string nome) :
            base(costo, id, quantita, nome)
        {
            NumPagine = numpagine;
            Autore = autore;
            Genere = genere;
        }
        public override void Proprieta()
        {
            Console.WriteLine("Costo: " + Costo);
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Quantita: " + Quantita);
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Numpagine: " + NumPagine);
            Console.WriteLine("Autore: " + Autore);
            Console.WriteLine("Genere: " + Genere);
            Console.Write("\n");
        }
    }
}
