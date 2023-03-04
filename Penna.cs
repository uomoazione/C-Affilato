using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programMain
{
    class Penna : Prodotto
    {
        private string _marca;

        public override double Costo { get { return _costo; } set { _costo = ValorePos(value); } }
        public override string ID { get; set; }
        public override int Quantita { get; set; }
        public override string Nome { get; set; }
        public string Marca { get; set; }


        public Penna(string marca, double costo, string id, int quantita, string nome) : base(costo, id, quantita, nome)
        {
            Marca = marca;
        }
        public override void Proprieta()
        {
            Console.WriteLine("Costo: " + Costo);
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Quantita: " + Quantita);
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Marca: " + Marca);
            Console.Write("\n");
        }
    }
}
