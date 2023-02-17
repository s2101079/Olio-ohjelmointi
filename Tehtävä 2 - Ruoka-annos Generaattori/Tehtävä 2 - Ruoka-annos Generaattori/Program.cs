using System;
(paaruoka pääruoka, lisuke Lisuke, kastike Kastike) Ruokannos;

while (true)
{
    Console.WriteLine("pääraaka-aine (nautaa, kanaa, kasviksia): ");
    if (Enum.TryParse<paaruoka>(Console.ReadLine(), ignoreCase: true, out var pää))
    {
        Ruokannos.pääruoka = pää;
        break;
    }
    else
    {
        Console.WriteLine("Et pysty tekemään näin");
    }
}

while(true)
{
    Console.WriteLine("lisuke (perunaa, riisiä, pastaa): ");
    if (Enum.TryParse<lisuke>(Console.ReadLine(), ignoreCase: true, out var lisä))
    {
        Ruokannos.Lisuke = lisä;
        break;

    }
    else
    {
        Console.WriteLine("Et pysty tekemään näin");
    }
}

while(true)
{
    Console.WriteLine("kastike (curry, hapanimelä, pippuri, chili): ");
    if (Enum.TryParse<kastike>(Console.ReadLine(), ignoreCase: true, out var kast))
    {
        Ruokannos.Kastike = kast;
        break;
    }

    else
    {
        Console.WriteLine("Et pysty tekemään näin");
    }
}

Console.WriteLine($"{Ruokannos.pääruoka} ja {Ruokannos.Lisuke}, {Ruokannos.Kastike}-Kastikkeella");

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
