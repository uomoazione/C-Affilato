using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;


namespace programMain
{
    class Ordine
    {
        //private List<Prodotto> Carrello;
        private double costot;

        public List<Prodotto> Carrello { get; set; }
        public IOrderedEnumerable<Prodotto> RiepilogoCarrelo { get; set; }

        public Ordine()
        {
            Carrello = new List<Prodotto>();
        }

        public void AggiungiProdotto(Prodotto prodotto)
        {
            Carrello.Add(prodotto);
        }
        public void OrdinaPerCosto()
        {
            RiepilogoCarrelo =
            from prodotto in Carrello
            orderby prodotto.Costo
            select prodotto;
        }
        public void Showcase()
        {
            foreach (var prodotto in RiepilogoCarrelo)
            {
                costot += prodotto.Tot;
                prodotto.Proprieta();
            }
            Console.WriteLine("\n Spesa totale:" + costot);
        }
    }
}
