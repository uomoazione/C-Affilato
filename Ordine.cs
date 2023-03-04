using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;


namespace programMain
{
    class Ordine
    {
        //public List<Prodotto> Carrello;
        private List<Prodotto> Carrello { get; set; }
        private IOrderedEnumerable<Prodotto> RiepilogoCarrelo { get; set; }

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
                prodotto.Proprieta();
            }
        }
    }
}
