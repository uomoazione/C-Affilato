using programMain;

internal class Program
{
    private static void Main()
    {
        Ordine CarrelloSpesa = new();
        Libro QuandoTuttoInizia = new(200, "FabioVolo", "Rosa", 20, "1", 1, "QuandoTuttoInizia");
        Penna PennaBicNera = new("BIC", 1, "2", 1, "PennaBicNera");
        Penna PennaBicRossa = new("BIC!", 1.5, "3", 1, "PennaBicRossa");
        CarrelloSpesa.AggiungiProdotto(QuandoTuttoInizia);
        CarrelloSpesa.AggiungiProdotto(PennaBicNera);
        CarrelloSpesa.AggiungiProdotto(PennaBicRossa);
        CarrelloSpesa.OrdinaPerCosto();
        CarrelloSpesa.Showcase();
    }
}