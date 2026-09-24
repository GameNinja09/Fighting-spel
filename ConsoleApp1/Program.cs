using NAudio.Wave;

int HP1 = 100;
string Char1 = "Bobban";

int HP2 = 100;
string Char2 = "kloggen";

Console.WriteLine($"{Char1} kontra {Char2}, båda har 100 HP. FIGHT!");

while (true)
{
    int slagStyrkaB = Random.Shared.Next(0, 9);
    if (slagStyrkaB >= 8)
    {
        int crit = Random.Shared.Next(11, 20);
        Console.WriteLine(crit);
        HP2 = HP2 - crit;
        int dialog1=Random.Shared.Next(0,10);
        if(dialog1<=4){
            Console.WriteLine($"Jävlar i min lilla låda!! {Char2} tog ett slag rakt i nyllet!!");
        }
        else if(dialog1>=5){
            Console.WriteLine($"Åh fy helsike det där kan bara ha gjort ont för stackars {Char2}");
        }
        Console.WriteLine($"{Char1} har {HP1} och {Char2} har {HP2}");
        Console.ReadKey();

        if (HP1 <= 0 || HP2 <= 0)
        {
            break;
        }
    }

    int slagStyrkaK = Random.Shared.Next(0, 9);
    if (slagStyrkaK >= 8)
    {
        int crit = Random.Shared.Next(11, 20);
        Console.WriteLine(crit);
        HP1 = HP1 - crit;
        int dialog2=Random.Shared.Next(0,10);
        if(dialog2<=4){
            Console.WriteLine($"Jävlar i min lilla låda!! {Char1} tog ett slag rakt i nyllet!!");
        }
        else if(dialog2>=5){
            Console.WriteLine($"Åh fy helsike det där kan bara ha gjort ont för stackars {Char1}");
        }
        Console.WriteLine($"{Char1} har {HP1} och {Char2} har {HP2}");
        Console.ReadKey();

        if (HP1 <= 0 || HP2 <= 0)
        {
            break;
        }
    }

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

// var player = new WasapiPlayerBuilder().Build();
// var auidoFile = new AudioFileReader("klocka.wav");
// Fick inte skiten att fungera