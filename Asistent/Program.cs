while (true)
{
 Console.Write("Zadaj príkaz (sum, odm, find, help, rect, array): ");
 string prikaz = Console.ReadLine();
     if (prikaz == "sum")
     {
         sum();
     }
     else if (prikaz == "odm")
     {
         odm();
     }
     else if (prikaz == "find")
     {
         find();
     }
     else if (prikaz == "help")
     {
      help();
     }
     else if (prikaz == "rect")
     {
         rect();
     }
     else if (prikaz == "array")
     {
         array();
     }
     else if (prikaz == "exit")
     {
         break;
     }
     else
     { 
         Console.WriteLine();
         Console.WriteLine("Zadaj správny príkaz.");
         Console.WriteLine();
     }
}
void sum()
{
  Console.WriteLine();
  Console.WriteLine("Rozumiem, robíme operáciu sum.");
  Console.WriteLine();
  Console.Write("Zadaj prvé číslo: ");
  if (!int.TryParse(Console.ReadLine(), out int sum1))
  {
      Console.WriteLine();
      Console.WriteLine("Chyba, neplatné číslo.");
      Console.WriteLine();
      return;
  }
  Console.WriteLine();
  Console.Write("Zadaj druhé číslo: ");
  if (!int.TryParse(Console.ReadLine(), out int sum2))
  {
      Console.WriteLine();
      Console.WriteLine("Chyba, neplatné číslo.");
      Console.WriteLine();
      return;
  }
  Console.WriteLine();
  int sum_vysledok = sum1 + sum2;
  Console.WriteLine($"{sum1} + {sum2} = {sum_vysledok}");
  Console.WriteLine();
}
void odm()
{
  Console.WriteLine();
  Console.WriteLine("Rozumiem, robíme operáciu odm.");
  Console.WriteLine();
  Console.Write("Zadaj číslo: ");
  if (!int.TryParse(Console.ReadLine(), out int odm) || odm < 0)
  {
      Console.WriteLine();
      Console.WriteLine("Chyba, neplatné číslo.");
      Console.WriteLine();
      return;
  }
  Console.WriteLine();
  double odm_vysledok = Math.Sqrt(odm);
  Console.WriteLine($"Odmocnina z čísla {odm} je {odm_vysledok}."); 
  Console.WriteLine();
}
void find()
{
  Console.WriteLine();
  Console.WriteLine("Rozumiem, robíme operáciu find.");
  Console.WriteLine();
  Console.Write("Zadaj text: ");
  string text = Console.ReadLine();
  Console.WriteLine();
  Console.Write("Zadaj hľadaný podreťazec: ");
  string podretazec = Console.ReadLine();
  Console.WriteLine();
 if ((text.ToLower()).Contains(podretazec.ToLower()))
 {
     Console.WriteLine("Podreťazec sa v texte nachádza.");
 }
 else
 {
     Console.WriteLine("Podreťazec sa v texte nenachádza.");
 }
 Console.WriteLine();
}
void help()
{
  Console.WriteLine();
  Console.WriteLine("Operácie a ich využitie:");
  Console.WriteLine("sum - sčíta dve čísla");
  Console.WriteLine("odm - odmocní číslo");
  Console.WriteLine("find - nájde podreťazec vo vete");
  Console.WriteLine("help - vypíše všetky podporované príkazy");
  Console.WriteLine("rect - zapne mód merania obdĺžnikov");
  Console.WriteLine("     - area - vypočíta obsah obdlžníka");
  Console.WriteLine("     - perimeter - vypočíta obsah obdĺžnika");
  Console.WriteLine("     - diagonal - vypočíta dĺžku uhlopriečky obĺžnika");
  Console.WriteLine("array - zapne mód práce s poľom");
  Console.WriteLine("      - find - nájde zadané číslo a jeho pozíciu v poli");
  Console.WriteLine("      - min - zoradí pole od najmenšieho čísla, po najväčšie");
  Console.WriteLine("      - sort - nájde minimálnu hodnotu v poli");
  Console.WriteLine();
}
void rect()
{
  Console.WriteLine();
  Console.WriteLine("Rozumiem, robíme mód rect.");
  Console.WriteLine();
  Console.Write("Zadaj dĺžku strany a: ");
  if (!int.TryParse(Console.ReadLine(), out int rect_a) || rect_a <= 0)
  {
      Console.WriteLine();
      Console.WriteLine("Chyba, neplatné číslo.");
      Console.WriteLine();
      return;
  }
  Console.WriteLine();
  Console.Write("Zadaj dĺžku strany b: ");
  if (!int.TryParse(Console.ReadLine(), out int rect_b) || rect_b <=  0)
  {
      Console.WriteLine();
      Console.WriteLine("Chyba, neplatné číslo.");
      Console.WriteLine();
      return;
  }
  Console.WriteLine();
  while (true)
  {
      Console.Write($"Rozumiem, máme obdĺžnik v rozmere {rect_a}x{rect_b}, zadaj príkaz (area, perimeter, diagonal): ");
      string prikaz_rect = Console.ReadLine();
      Console.WriteLine();
      if (prikaz_rect == "area")
      {
          Console.WriteLine($"Area = {rect_a * rect_b}.");
      }
      else if (prikaz_rect == "perimeter")
      {
          Console.WriteLine($"Perimeter = {2 * rect_a + 2 * rect_b}.");
      }
      else if (prikaz_rect == "diagonal")
      {
          Console.WriteLine($"Diagonal = {Math.Sqrt(rect_a * rect_a + rect_b * rect_b)}.");
      }
      else if (prikaz_rect == "exit")
      {
          Environment.Exit(0);
      }
      else
      {
          Console.WriteLine("Chyba, zadaj správny príkaz.");
      }
      Console.WriteLine();
  }
}
void array()
{
   Console.WriteLine();
   Console.WriteLine("Rozumiem, robíme mód array.");
   Console.WriteLine();
   Console.Write("Zadaj číselné pole (príklad: 1 0 9 1 2): ");
   string[] array_vstup = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
   int[] array = new int[array_vstup.Length];
   for (int i = 0; i < array_vstup.Length; i++)
   {
       array[i] = int.Parse(array_vstup[i]);
   }
   Console.WriteLine();
   while (true)
   {
       Console.Write("Rozumiem, zadaj príkaz (find, min, sort): ");
       string prikaz_array = Console.ReadLine();
       Console.WriteLine();
       if (prikaz_array == "find")
       {
           Console.Write("Zadaj hladané číslo: ");
           if (!int.TryParse(Console.ReadLine(), out int array_find))
           {
               Console.WriteLine();
               Console.WriteLine("Chyba, neplatné číslo.");
               Console.WriteLine();
               return;
           }
           Console.WriteLine();
           for (int i = 0; i < array.Length; i++)
           {
               if (array_find == array[i])
               {
                   Console.WriteLine($"Číslo {array_find} sa nachádza na pozícii {i+1}.");
               }
           }
           Console.WriteLine();
       }
       else if(prikaz_array == "min")
       {
           int array_min = array[0];
           for (int i = 1; i < array.Length; i++)
           {
               if (array[i] < array_min)
               {
                   array_min = array[i];
               }
           }
           Console.WriteLine($"Najmenšie číslo je {array_min}.");
           Console.WriteLine();
       }
       else if (prikaz_array == "sort")
       {
           Array.Sort(array);
           Console.WriteLine($"Zoradené pole je {string.Join(" ", array)}.");
           Console.WriteLine();
       }
       else if (prikaz_array == "exit")
       {
           Environment.Exit(0);
       }
       else
       {
           Console.WriteLine("Chyba, zadaj správny príkaz");
       }
   }
}