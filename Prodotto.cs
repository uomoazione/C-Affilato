using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace programMain
{
    abstract class Prodotto
    {
        protected double _costo;
        private string _id;// get;set; crea i campi in auto dietro le quinte,
        private int _quantita;

        abstract public double Costo { get; set; } //deleghiamo le classi figlie a fare il controllo
        abstract public string ID { get; set; }
        abstract public int Quantita { get; set; }
        abstract public string Nome { get; set; }

        public Prodotto(double costo, string id, int quantita, string nome)
        {
            Costo = costo;
            ID = id;
            Quantita = quantita;
            Nome = nome;
        }
        protected double ValorePos(double costo)
        {
            if (costo < 0)
                return costo * (-1);
            return costo;
        }
        public virtual void Proprieta()
        {
            Console.WriteLine("Costo: " + Costo);
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Quantita: " + Quantita);
            Console.WriteLine("Nome: " + Nome);
        }
    }
}
