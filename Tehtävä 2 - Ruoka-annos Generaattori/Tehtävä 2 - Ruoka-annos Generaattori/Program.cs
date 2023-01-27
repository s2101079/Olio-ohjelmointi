using System;
string pääruoka = "idk";
string lisuke1 = "idk";
string kastike1 = "idk";

while (pääruoka == "idk")
{
    Console.WriteLine("pääraaka-aine (nautaa, kanaa, kasviksia): ");
    if (Enum.TryParse<paaruoka>(Console.ReadLine(), ignoreCase: true, out var pää))
    {

        switch (pää)
        {

        case paaruoka.nautaa:
            pääruoka = "nautaa";
            break;

        case paaruoka.kanaa:
            pääruoka = "kanaa";
            break;

        case paaruoka.kasviksia:
            pääruoka = "kasviksia";
            break;

        default:
            break;
        }

    }
    else
    {
        Console.WriteLine("Et pysty tekemään näin");

    }
}

while(lisuke1 == "idk")
{
    Console.WriteLine("lisuke (perunaa, riisiä, pastaa): ");
    if (Enum.TryParse<lisuke>(Console.ReadLine(), ignoreCase: true, out var lisä))
    {
        switch (lisä)
        {

            case lisuke.perunaa:
                lisuke1 = "perunaa";
                break;
            
            case lisuke.riisiä:
                lisuke1 = "riisiä";
                break;
            
            case lisuke.pastaa:
                lisuke1 = "pastaa";
                break;

            default:
                break;
        }
    }
    else
    {
        Console.WriteLine("Et pysty tekemään näin");
    }
}

while(kastike1 == "idk")
{
    Console.WriteLine("kastike (curry, hapanimelä, pippuri, chili): ");
    if (Enum.TryParse<kastike>(Console.ReadLine(), ignoreCase: true, out var kast))
    {
        switch (kast)
        {

            case kastike.chili:
                kastike1 = "chili";
                break;
            
            case kastike.curry:
                kastike1 = "curry";
                break;
            
            case kastike.hapanimelä:
                kastike1 = "hapanimelä";
                break;
            
            case kastike.pippuri:
                kastike1 = "pippuri";
                break;

            default:
                break;
        }
    }

    else
    {
        Console.WriteLine("Et pysty tekemään näin");
    }
}

(string pRuoka, string lRuoka, string kRuoka) ateria = (pääruoka, lisuke1, kastike1);
Console.WriteLine($"{ateria.pRuoka} Ja { ateria.lRuoka} { ateria.kRuoka}-kastikkeella");

enum paaruoka
{
    nautaa,
    kanaa,
    kasviksia,
}
enum lisuke
{
    perunaa,
    riisiä,
    pastaa,
}
enum kastike
{
    curry,
    hapanimelä,
    pippuri,
    chili,
}

