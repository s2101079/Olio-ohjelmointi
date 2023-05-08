using System;
Robotti roboto = new Robotti();

while (true)
{
    Console.WriteLine("mitä käskyjä haluat syöttää valintoja : Käynnistä, Sammuta, Ylös, Alas, Oikea tai Vasen" );
    string valinta1 = Console.ReadLine();
    if (valinta1 == "Käynnistä")
    {
        roboto.Käskyt[0] = new käynnistä();
    }
    if (valinta1 == "Sammuta")
    {
        roboto.Käskyt[0] = new sammuta();
    }
    if (valinta1 == "Ylös")
    {
        roboto.Käskyt[0] = new YlösKäsky();
    }
    if (valinta1 == "Alas")
    {
        roboto.Käskyt[0] = new AlasKäsky();
    }
    if (valinta1 == "Oikea")
    {
        roboto.Käskyt[0] = new OikeaKäsky();
    }
    if (valinta1 == "Vasen")
    {
        roboto.Käskyt[0] = new VasenKäsky();
    }

    Console.WriteLine("mitä käskyjä haluat syöttää valintoja : Käynnistä, Sammuta, Ylös, Alas, Oikea tai Vasen");
    string valinta2 = Console.ReadLine();
    if (valinta1 == "Käynnistä")
    {
        roboto.Käskyt[1] = new käynnistä();
    }
    if (valinta2 == "Sammuta")
    {
        roboto.Käskyt[1] = new sammuta();
    }
    if (valinta2 == "Ylös")
    {
        roboto.Käskyt[1] = new YlösKäsky();
    }
    if (valinta2 == "Alas")
    {
        roboto.Käskyt[1] = new AlasKäsky();
    }
    if (valinta2 == "Oikea")
    {
        roboto.Käskyt[1] = new OikeaKäsky();
    }
    if (valinta2 == "Vasen")
    {
        roboto.Käskyt[1] = new VasenKäsky();
    }

    Console.WriteLine("mitä käskyjä haluat syöttää valintoja : Käynnistä, Sammuta, Ylös, Alas, Oikea tai Vasen");
    string valinta3 = Console.ReadLine();
    if (valinta1 == "Käynnistä")
    {
        roboto.Käskyt[2] = new käynnistä();
    }
    if (valinta3 == "Sammuta")
    {
        roboto.Käskyt[2] = new sammuta();
    }
    if (valinta3 == "Ylös")
    {
        roboto.Käskyt[2] = new YlösKäsky();
    }
    if (valinta3 == "Alas")
    {
        roboto.Käskyt[2] = new AlasKäsky();
    }
    if (valinta3 == "Oikea")
    {
        roboto.Käskyt[2] = new OikeaKäsky();
    }
    if (valinta3 == "Vasen")
    {
        roboto.Käskyt[2] = new VasenKäsky();
    }

    roboto.Suorita();
    break;
}


public class Robotti
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool OnKäynnissä { get; set; }
    public IRobottiKäsky?[] Käskyt { get; } = new IRobottiKäsky?[3];

    public void Suorita()
    {
        foreach (IRobottiKäsky? käsky in Käskyt)
        {
            käsky?.Suorita(this);
            Console.WriteLine($"[{X} {Y} {OnKäynnissä}]");
        }
    }
}

public interface IRobottiKäsky
{
    void Suorita(Robotti robo);
}
public class käynnistä : IRobottiKäsky
{
    public void Suorita(Robotti robo)
    {
        robo.OnKäynnissä = true;
    }
}
public class sammuta : IRobottiKäsky
{
    public void Suorita(Robotti robo)
    {
        robo.OnKäynnissä = false;
    }
}

public class YlösKäsky : IRobottiKäsky
{
    public void Suorita(Robotti robo)
    {
        if (robo.OnKäynnissä == true)
        {
            robo.Y += 1;
        }
    }
}
public class AlasKäsky : IRobottiKäsky
{
    public void Suorita(Robotti robo)
    {
        if (robo.OnKäynnissä == true)
        {
            robo.Y -= 1;
        }
    }
}
public class VasenKäsky : IRobottiKäsky
{
    public void Suorita(Robotti robo)
    {
        if (robo.OnKäynnissä == true)
        {
            robo.X += 1;
        }
    }
}
public class OikeaKäsky : IRobottiKäsky
{
    public void Suorita(Robotti robo)
    {
        if (robo.OnKäynnissä == true)
        {
            robo.X -= 1;
        }
    }
}