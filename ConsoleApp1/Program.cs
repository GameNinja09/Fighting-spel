int HP1 = 100;
string Char1 = "Bobban";

int HP2 = 100;
string Char2 = "kloggen";

Console.WriteLine($"{Char1} kontra {Char2}, båda har 100 HP. FIGHT!");

int damage = Random.Shared.Next(0, 11);


while (true)
{
    Console.WriteLine($"PANG {Char1} och {Char2} slår varandra");
    HP1 = HP1 - damage;
    HP2 = HP2 - damage;
    Console.WriteLine(" "+HP1 + " "+ HP2);
    Console.ReadKey();
}



















// while (true)
// {
//     Console.WriteLine(hp);
//     hp -= 10;
//     if (hp <= 0)
//     {
//         break;
//     }
//     Console.ReadKey();
// }
// if (hp <= 0)
// {
//     Console.WriteLine("Hp dog/fick slut på hälsa");
//     Console.ReadKey();
// }
