using System;
DamageSystem damageSys = new DamageSystem();
hahmo pelaaja = new hahmo();
vihollinen enemy = new vihollinen();
inventory inv = new inventory(0, 0);


while (true)
{

    while (true)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("haluatko lähteä 1 - taistelemaan tai 2 - käydä kaupassa?");
        string valinta = Console.ReadLine();
        if (valinta == "1")
        {
            break;
        }
        if (valinta == "2")
        {
            Console.WriteLine("Sinulla on " + pelaaja.kulta + " Kultaa");
            Console.WriteLine("Mitä haluaisit ostaa");
            Console.WriteLine("1 - Healing potion (Hinta = 15 kultaa)");
            Console.WriteLine(" Tai ");
            Console.WriteLine("2 - Damage potion (Hinta = 20 kultaa)");
            string osto = Console.ReadLine();
            if (osto == "1" && pelaaja.kulta >= 15 && inv.slot1 == 0)
            {

                if (inv.slot2 == 0)
                {
                    pelaaja.kulta -= 15;
                    inv = new Healing();
                }
                else if (inv.slot2 == 1)
                {
                    Console.WriteLine("Voit ostaa vain yhden potionin");
                }


            }

            else if (osto == "2" && pelaaja.kulta >= 20 && inv.slot2 == 0)
            {
                if (inv.slot1 == 0)
                {
                    inv = new damaging();
                    pelaaja.kulta -= 20;
                }

                else if (inv.slot1 == 1)
                {
                    Console.WriteLine("Voit ostaa vain yhden potionin");
                }

            }

            else
            {
                Console.WriteLine("Sinulla ei ole varaa tähän tai olet jo ostanut potionin");
            }
        }
    }

    while (true)
    {
        Console.WriteLine("haluatko taistella tuli-, jää- tai kiviliskoa vastaan");
        string lisko = Console.ReadLine();
        if (lisko == "tuli")
        {

            damageSys.VihollinenValintaTuli();
            enemy.Health = 15;
            break;
        }
        if (lisko == "jää")
        {
            damageSys.VihollinenValintaJää();
            enemy.Health = 20;
            break;
        }
        if (lisko == "kivi")
        {
            damageSys.VihollinenValintaKivi();
            enemy.Health = 30;
            break;
        }
    }

    while (true)
    {
        Console.WriteLine("haluatko käyttää tuli-, jää- tai kivi miekkaa");
        string sword = Console.ReadLine();
        if (sword == "tuli")
        {
            damageSys.MiekkakavalintaTuli();
            break;

        }
        if (sword == "jää")
        {
            damageSys.MiekkakavalintaJää();
            break;

        }
        if (sword == "kivi")
        {
            damageSys.MiekkakavalintaKivi();
            break;

        }

    }

    while (true)
    {
        Console.WriteLine("haluatko käyttää tuli-, jää- tai kivi haarniskaa");
        string armor = Console.ReadLine();
        if (armor == "tuli")
        {
            damageSys.HaarniskavalintaTuli();
            pelaaja.hp = 25;
            break;
        }
        if (armor == "jää")
        {
            damageSys.HaarniskavalintaJää();
            pelaaja.hp = 20;
            break;
        }
        if (armor == "kivi")
        {
            damageSys.HaarniskavalintaKivi();
            pelaaja.hp = 35;
            break;
        }

    }




    while (true)
    {

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" Ritari: " + pelaaja.hp + "health " + "Lisko: " + enemy.Health + "health");
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("1 - Hyökkää miekalla");
        Console.WriteLine("2 - Puolustaudu kilvellä");
        if (inv.slot2 == 1)
        {
            Console.WriteLine("3 - Käytä Healing potion");
        }
        if (inv.slot1 == 1)
        {
            Console.WriteLine("4 - Käytä Damaging potion");
        }
        Console.WriteLine("Mitä Haluat Tehdä?");

        int AttackedWith = Convert.ToInt32(Console.ReadLine());

        if (AttackedWith >= 1 && AttackedWith <= 4)
        {
            if (AttackedWith == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hyökkäät miekallasi");
                float hostiledmg = damageSys.damageEnemy();
                float playerdmg = damageSys.damagePlayer();
                Console.WriteLine("Teet Liskolle " + hostiledmg + " pistettä vahinkoa");
                Console.WriteLine("Lisko tekee " + playerdmg + " pistettä vahinkoa");
                enemy.Health -= hostiledmg;
                pelaaja.hp -= playerdmg;

            }


            if (AttackedWith == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Puolustaudut kilvellä");

                float playerdmg = damageSys.damagePlayer() / 2;
                Console.WriteLine("Suojaudut Liskoa vastaan, Lisko tekee vain " + playerdmg + " pistettä vahinkoa");
                pelaaja.hp -= playerdmg;
            }
            if (AttackedWith == 3)
            {
                Console.WriteLine("Käytät Healing potionin");
                inv.slot2 = 0;
                pelaaja.hp += 5;
            }
            if (AttackedWith == 4)
            {
                Console.WriteLine("Käytät Damaging potionin");
                enemy.Health -= 5;
                inv.slot1 = 0;
            }

        }

        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Valitse Numero 1 tai 2");
        }

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Haluatko valita 1 - uuden miekan tai 2 - jatkaa samalla ");
            string valinta = Console.ReadLine();
            if (valinta == "1")
            {
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    damageSys.miekkapoisto();
                    Console.WriteLine("haluatko käyttää tuli-, jää- tai kivi miekkaa");
                    string sword = Console.ReadLine();
                    if (sword == "tuli")
                    {
                        damageSys.MiekkakavalintaTuli();
                        break;

                    }
                    if (sword == "jää")
                    {
                        damageSys.MiekkakavalintaJää();
                        break;

                    }
                    if (sword == "kivi")
                    {
                        damageSys.MiekkakavalintaKivi();
                        break;

                    }

                }
            }
            if (valinta == "2")
            {
                break;
            }

            break;

        }

        if (pelaaja.hp <= 0 || enemy.Health <= 0)
        {
            break;
        }


    }

    if (pelaaja.hp >= 1)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("voitit");
        pelaaja.kulta += 25;
    }
    if (enemy.Health >= 1)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Hävisit");
        pelaaja.kulta += 5;
    }

}



public class hahmo
{
    public float hp { get; set; }
    public float kulta { get; set; }

    public hahmo()
    {

    }
    public hahmo(float _kulta)
    {
        kulta += _kulta;
    }

}
public class inventory
{
    public float slot1 { get; set; }
    public float slot2 { get; set; }

    public inventory(float _slot1, float _slot2)
    {
        slot1 += _slot1;
        slot2 += _slot2;
    }


}
public class damaging : inventory
{
    public damaging() : base(1, 0)
    {

    }
}
public class Healing : inventory
{
    public Healing() : base(0, 1)
    {

    }
}
public class vihollinen
{
    public float Health { get; set; }

    public vihollinen()
    {

    }
}

public class DamageSystem
{
    public float damageToPlayer;
    public float damageToEnemy;
    public bool tulimiekka { get; set; }
    public bool jäämiekka { get; set; }
    public bool kivimiekka { get; set; }

    public bool tuliHaarniska { get; set; }
    public bool jääHaarniska { get; set; }
    public bool kiviHaarniska { get; set; }

    public bool tuliLisko { get; set; }
    public bool jääLisko { get; set; }
    public bool kiviLisko { get; set; }


    public Random dmg = new Random();


    public float damagePlayer()
    {
        if (tuliLisko == true)
        {
            if (tuliHaarniska == true)
            {
                damageToPlayer = dmg.Next(1, 3);
            }
            if (jääHaarniska == true)
            {
                damageToPlayer = dmg.Next(1, 4);
            }
            if (kiviHaarniska == true)
            {
                damageToPlayer = dmg.Next(0, 3);
            }
        }
        if (jääLisko == true)
        {
            if (tuliHaarniska == true)
            {
                damageToPlayer = dmg.Next(1, 5);
            }
            if (jääHaarniska == true)
            {
                damageToPlayer = dmg.Next(0, 2);
            }
            if (kiviHaarniska == true)
            {
                damageToPlayer = dmg.Next(0, 4);
            }
        }
        if (kiviLisko == true)
        {
            if (tuliHaarniska == true)
            {
                damageToPlayer = dmg.Next(0, 3);
            }
            if (jääHaarniska == true)
            {
                damageToPlayer = dmg.Next(0, 3);
            }
            if (kiviHaarniska == true)
            {
                damageToPlayer = dmg.Next(1, 4);
            }
        }

        return damageToPlayer;
    }

    public float damageEnemy()
    {
        if (tuliLisko == true)
        {
            if (tulimiekka == true)
            {
                damageToEnemy = dmg.Next(0, 1);
            }
            if (jäämiekka == true)
            {
                damageToEnemy = dmg.Next(1, 3);
            }
            if (kivimiekka == true)
            {
                damageToEnemy = dmg.Next(0, 3);
            }
        }
        if (jääLisko == true)
        {
            if (tulimiekka == true)
            {
                damageToEnemy = dmg.Next(1, 5);
            }
            if (jäämiekka == true)
            {
                damageToEnemy = dmg.Next(0, 1);
            }
            if (kivimiekka == true)
            {
                damageToEnemy = dmg.Next(0, 3);
            }
        }
        if (kiviLisko == true)
        {
            if (tulimiekka == true)
            {
                damageToEnemy = dmg.Next(1, 3);
            }
            if (jäämiekka == true)
            {
                damageToEnemy = dmg.Next(1, 3);
            }
            if (kivimiekka == true)
            {
                damageToEnemy = dmg.Next(0, 5);
            }
        }

        return damageToEnemy;
    }

    public bool VihollinenValintaTuli()
    {
        return tuliLisko = true;
    }

    public bool VihollinenValintaJää()
    {
        return jääLisko = true;
    }
    public bool VihollinenValintaKivi()
    {
        return kiviLisko = true;
    }
    public bool HaarniskavalintaTuli()
    {
        return tuliHaarniska = true;
    }
    public bool HaarniskavalintaJää()
    {
        return jääHaarniska = true;
    }
    public bool HaarniskavalintaKivi()
    {
        return kiviHaarniska = true;
    }
    public bool MiekkakavalintaTuli()
    {
        return tulimiekka = true;
    }
    public bool MiekkakavalintaJää()
    {
        return jäämiekka = true;
    }
    public bool MiekkakavalintaKivi()
    {
        return kivimiekka = true;
    }

    public void miekkapoisto()
    {
        tulimiekka = false;
        jäämiekka = false;
        kivimiekka = false;
    }

}






