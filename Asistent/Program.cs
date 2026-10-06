while (true)
{
    Console.Write("Zadaj príkaz(sum, odm, find, help): ");
    string prikaz = Console.ReadLine();
    Console.WriteLine();
    if (prikaz == "sum" || prikaz == "odm" || prikaz == "find" || prikaz == "help" || prikaz == "exit")
    {
        if (prikaz == "sum")
        {
            Console.WriteLine("Rozumiem, robíme operáciu sum.");
            Console.WriteLine();
            Console.Write("Zadaj prvé číslo: ");
            int sum1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Zadaj druhé číslo: ");
            int sum2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Sum(sum1, sum2);
            Console.WriteLine();
        }
        if (prikaz == "odm")
        {
            Console.WriteLine("Rozumiem, robíme operáciu odm.");
            Console.WriteLine();
            Console.Write("Zadaj číslo: ");  
            int odm = int.Parse(Console.ReadLine());
            if (odm >= 0)
            {
                Console.WriteLine();
                Odm(odm);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Chyba, záporné čísla sa odmocňovať nedá.");
                Console.WriteLine();
            }
        }
        if (prikaz == "find")
        {
            Console.WriteLine("Rozumiem, robíme operáciu find.");
            Console.WriteLine();
            Console.Write("Zadaj text: ");
            string text = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Zadaj hľadaný podreťazec: ");
            string podretazec = Console.ReadLine();
            Console.WriteLine();
            Find(text,podretazec);
            Console.WriteLine();
        }
        if (prikaz == "help")
        {
            Console.WriteLine("Operácie a ich využitie:");
            Console.WriteLine("sum - sčíta dve čísla");
            Console.WriteLine("odm - odmocní číslo");
            Console.WriteLine("find - nájde podreťazec vo vete");
            Console.WriteLine("help - vypíše všetky podporované príkazy");
            Console.WriteLine();
        }
        if (prikaz == "exit")
        {
            break;
        }
    }
    else
    {
        Console.WriteLine("Zadaj správny príkaz.");
        Console.WriteLine();
    }
}
int Sum(int sum1, int sum2)
{
    int sum_vysledok = sum1 + sum2;
    Console.WriteLine($"{sum1} + {sum2} = {sum_vysledok}.");
    return sum_vysledok;
}
double Odm(int odm)
{
    double odm_vysledok = Math.Sqrt(odm);
    Console.WriteLine($"Odmocnina z čísla {odm} je {odm_vysledok}.");
    return odm_vysledok;
}
void Find(string text, string podretazec)
{
    if ((text.ToLower()).Contains(podretazec.ToLower()))
    {
        Console.WriteLine("Podreťazec sa v texte nachádza.");
    }
    else
    {
        Console.WriteLine("Podreťazec sa v texte nenachádza.");
    }
}