using System;
Nuoli arrow = new Nuoli();

while (true)
{
    Console.WriteLine("kärki (puu, teräs tai timantti) ");

    if (Enum.TryParse(Console.ReadLine(), out Nuoli.kärki Nuolenkärki))
    {
        // saadan nuolen hinta
        arrow.setkärki(Convert.ToInt32(Nuolenkärki));
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
        arrow.setperä(Convert.ToInt32(Nuolenperä));
        break;
    }
    else
    {
        Console.WriteLine("Et pysty tekemään näin");

    }
}
while (arrow.getpituus() >= 101 || arrow.getpituus() <= 59)
{
    Console.WriteLine("Valitse varsi (Pituus väliltä 60-100cm) ");
    arrow.setpituus(Convert.ToInt32(Console.ReadLine()));
    if (arrow.getpituus() <= 100 && arrow.getpituus() >= 60)
    {
        arrow.setpituus(arrow.getpituus() * 0.05f);
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
    private float pituus;
    private float ValKärki;
    private float ValPerä;

    public float getpituus()
    {
        return pituus;
    }

    public float getkärki()
    {
        return ValKärki;
    }

    public float getperä()
    {
        return ValPerä;
    }

    public void setpituus(float _pituus)
    {
        pituus = _pituus;
    }

    public void setkärki(float _kärki)
    {
        ValKärki = _kärki;
    }

    public void setperä(float _perä)
    {
        ValPerä = _perä;
    }

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
