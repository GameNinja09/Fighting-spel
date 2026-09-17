int HP1 = 100;
string Char1 = "Bobban";

int HP2 = 100;
string Char2 = "kloggen";

Console.WriteLine($"{Char1} kontra {Char2}, båda har 100 HP. FIGHT!");

while (true)
{
    int damage1 = Random.Shared.Next(0, 11);
    int damage2 = Random.Shared.Next(0, 11);

    Console.WriteLine($"PANG {Char1} och {Char2} slår varandra");
    HP1 = HP1 - damage1;
    HP2 = HP2 - damage2;
    Console.WriteLine($"{Char1} har {HP1} och {Char2} har {HP2}");
    Console.ReadKey();

    if (HP1 <= 0 || HP2 <= 0)
    {
        break;
    }
}

Console.WriteLine($"Det verkar som om någon har stupat, men vem?");
Console.ReadKey();

if (HP1 <= 0)
{
    Console.WriteLine($"{Char1} HAR STUPAT, {Char2} HAR VUNNIT");
    Console.ReadKey();
}
else if (HP2 <= 0)
{
    Console.WriteLine($"{Char2} HAR STUPAT, {Char1} HAR VUNNIT");
    Console.ReadKey();
}
Console.WriteLine($"Ohhh en så spännande match, bra kämpat, även om du strök med på kuppen!");
Console.ReadKey();