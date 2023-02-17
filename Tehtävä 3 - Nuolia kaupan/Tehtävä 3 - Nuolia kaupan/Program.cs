using System;
Nuoli arrow = new Nuoli();

while (true)
{
    Console.WriteLine("kärki (puu, teräs tai timantti) ");
    
    if(Enum.TryParse(Console.ReadLine(), out Nuoli.kärki Nuolenkärki))
    {
        // saadan nuolen hinta
        arrow.ValKärki = Convert.ToInt32(Nuolenkärki);
        break;
    }
    else
    {
        Console.WriteLine("Et pysty tekemään näin");
    }
}



while (true)
{
    Console.WriteLine("perä (lehti, kanansulka tai kotkansulka) ");
    if (Enum.TryParse(Console.ReadLine(), out Nuoli.perä Nuolenperä))
    {
        // saadan nuolen hinta
        arrow.ValPerä = Convert.ToInt32(Nuolenperä);
        break;
    }
    else
    {
        Console.WriteLine("Et pysty tekemään näin");

    }
}
while (arrow.pituus >= 101 || arrow.pituus <= 59)
{
    Console.WriteLine("Valitse varsi (Pituus väliltä 60-100cm) ");
    arrow.pituus = Convert.ToInt32(Console.ReadLine());
    if (arrow.pituus <= 100 && arrow.pituus >= 60)
    {
        arrow.pituus = arrow.pituus * 0.05f;
        break;
        
    }
    else
    {
        Console.WriteLine("pitää olla 60-100 cm välillä");
    }
}

Console.WriteLine($"Tämän nuolen hinta on {arrow.PalautaHinta()} kultaa");

public class Nuoli
{
    public float pituus;
    public float ValKärki;
    public float ValPerä;


  
    public float PalautaHinta()
    {
        //hinnat
        float hinta = pituus + ValKärki + ValPerä;
        return hinta;
    }

    public enum kärki
    {
        puu = 3,
        teräs = 5,
        timantti = 50,
    }
    public enum perä
    {
        lehti = 0,
        kanansulka = 1,
        kotkansulka = 5,
    }


}
