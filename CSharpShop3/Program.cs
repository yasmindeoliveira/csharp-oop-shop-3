// See https://aka.ms/new-console-template for more information
using CSharpShop3;
using CSharpShop3.CustomException;

try
{
    Acqua Bottiglia1 = new Acqua("Sant'Anna", "Acqua Minerale", 0.20f, 22, 1.5f, 6.9f, "Sant'Anna");
    Bottiglia1.Stampa();

    Bottiglia1.BeviAcqua(1);
    Bottiglia1.Stampa();

    Bottiglia1.RiempiBottiglia(0.7f);
    Bottiglia1.Stampa();

    Console.WriteLine("Contenuto in galloni: " + Acqua.DaLitriAGalloni(1.5));

}
catch(ResultCannotBeNegativeException e)
{
    Console.WriteLine(e.Message);
}catch(OverflowException e)
{
    Console.WriteLine(e.Message);
}


/*
Acqua Bottiglia1 = new Acqua("Sant'Anna", "Acqua Minerale", 0.20f, 22, 1.5f, 6.9f, "Sant'Anna");
Bottiglia1.Stampa();

Bottiglia1.BeviAcqua(1);
Bottiglia1.Stampa();

Bottiglia1.RiempiBottiglia(0.7f);
Bottiglia1.Stampa();

Bottiglia1.SvuotaBottiglia();
Bottiglia1.Stampa();

FruttaAPezzi Ananas = new FruttaAPezzi("Ananas", "Bromeliaceae", "Frutta", 1.5f, 10, true);
Ananas.Stampa();

Ananas.MangiaFrutta(4);
Ananas.Stampa();

Ananas.RiempiSacchetto(1);
Ananas.Stampa();

Prodotto lavatriceBosch = new Prodotto("LavatriceBosch", "Per bucato", 100, 22);
lavatriceBosch.Stampa();
*/