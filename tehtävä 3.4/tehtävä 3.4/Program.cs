using System;
Nuoli arrow = new Nuoli();
Nuoli Eliittinuoli = new Nuoli();
Nuoli Aloittelijanuoli = new Nuoli();
Nuoli Perusnuoli = new Nuoli();


while (true)
{
    Console.WriteLine("Haluatko valmiin tai kustomoidun nuolen");
    string valinta = Console.ReadLine();
    if (valinta == "valmiin")
    {
        Console.WriteLine("Haluatko eliittinuolen, aloittelijanuolen tai perusnuolen");
        string nuoliValinta = Console.ReadLine();
        if (nuoliValinta == "eliittinuolen")
        {
            Nuoli.LuoEliittiNuoli(Eliittinuoli);
            Console.WriteLine($"Tämän nuolen hinta on {Eliittinuoli.PalautaHinta()} kultaa");
            break;
        }
        if (nuoliValinta == "aloittelijanuolen")
        {
            Nuoli.LuoAloittelijaNuoli(Aloittelijanuoli);
            Console.WriteLine($"Tämän nuolen hinta on {Aloittelijanuoli.PalautaHinta()} kultaa");
            break;
        }
        if (nuoliValinta == "perusnuolen")
        {
            Nuoli.LuoPerusnuoli(Perusnuoli);
            Console.WriteLine($"Tämän nuolen hinta on {Perusnuoli.PalautaHinta()} kultaa");
            break;
        }
        break;
    }    
    if ( valinta == "kustomoidun")
    {
        while (true)
        {
            Console.WriteLine("kärki (puu, teräs tai timantti) ");

            if (Enum.TryParse(Console.ReadLine(), out Nuoli.kärki Nuolenkärki))
            {
                // saadan nuolen hinta
                switch (Nuolenkärki)
                {

                    case Nuoli.kärki.puu:
                        arrow.ValKärki = 3;
                        break;

                    case Nuoli.kärki.teräs:
                        arrow.ValKärki = 5;
                        break;

                    case Nuoli.kärki.timantti:
                        arrow.ValKärki = 50;
                        break;

                    default:
                        break;
                }
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
                switch (Nuolenperä)
                {

                    case Nuoli.perä.lehti:
                        arrow.ValPerä = 0;
                        break;

                    case Nuoli.perä.kanansulka:
                        arrow.ValPerä = 1;
                        break;

                    case Nuoli.perä.kotkansulka:
                        arrow.ValPerä = 5;
                        break;

                    default:
                        break;
                }
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
        break;
    }


}


public class Nuoli
{
    public float pituus
    {
        get; set;
    }
    public float ValKärki
    {
        get; set;
    }
    public float ValPerä
    {
        get; set;
    }


    public float PalautaHinta()
    {
        //hinnat
        float hinta = pituus + ValKärki + ValPerä;
        return hinta;
    }
    public Nuoli()
    {

    }

    public Nuoli(float Pituus, float kärki, float perä)
    {
        pituus = Pituus;
        ValKärki = kärki;
        ValPerä = perä;
    }
    public static Nuoli LuoEliittiNuoli(Nuoli eliittinuoli) 
    {
        eliittinuoli.ValKärki = 50;
        eliittinuoli.ValPerä = 5;
        eliittinuoli.pituus = 100 * 0.05f;
        return new Nuoli(eliittinuoli.pituus, eliittinuoli.ValKärki, eliittinuoli.ValPerä);
    }
    public static Nuoli LuoPerusnuoli(Nuoli eliittinuoli) 
    {
        eliittinuoli.ValKärki = 5;
        eliittinuoli.ValPerä = 1;
        eliittinuoli.pituus = 85 * 0.05f;
        return new Nuoli(eliittinuoli.pituus, eliittinuoli.ValKärki, eliittinuoli.ValPerä);
    }
    public static Nuoli LuoAloittelijaNuoli(Nuoli eliittinuoli) 
    {
        eliittinuoli.ValKärki = 3;
        eliittinuoli.ValPerä = 1;
        eliittinuoli.pituus = 70 * 0.05f;
        return new Nuoli(eliittinuoli.pituus, eliittinuoli.ValKärki, eliittinuoli.ValPerä);
    }

    public enum kärki
    {
        puu,
        teräs,
        timantti,
    }
    public enum perä
    {
        lehti,
        kanansulka,
        kotkansulka,
    }


}
