while (true)
{
 Console.Write("Zadaj príkaz (sum, odm, find, help, rect, array): ");
 string prikaz = Console.ReadLine();
     if (prikaz == "sum")
     {
         Sum();
     }
     else if (prikaz == "odm")
     {
         Odm();
     }
     else if (prikaz == "find")
     {
         Find();
     }
     else if (prikaz == "help")
     {
      Help();
     }
     else if (prikaz == "rect")
     {
         Rect();
     }
     else if (prikaz == "array")
     {
         Array();
     }
     else if (prikaz == "exit")
     {
         break;
     }
     else
     {
     Console.WriteLine("Zadaj správny príkaz.");
     }
}
void Sum()
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
  Console.WriteLine($"{sum1} + {sum2} = {sum_vysledok}.");
  Console.WriteLine();
}
void Odm()
{
  Console.WriteLine();
  Console.WriteLine("Rozumiem, robíme operáciu odm.");
  Console.WriteLine();
  Console.Write("Zadaj číslo: ");
  if (!int.TryParse(Console.ReadLine(), out int odm))
  {
      Console.WriteLine();
      Console.WriteLine("Chyba, neplatné číslo.");
      Console.WriteLine();
      return;
  }
  if (odm >= 0)
  {
      Console.WriteLine();
      double odm_vysledok = Math.Sqrt(odm);
      Console.WriteLine($"Odmocnina z čísla {odm} je {odm_vysledok}.");
      Console.WriteLine();
  }
  else
  {
      Console.WriteLine();
      Console.WriteLine("Chyba, záporné čísla sa odmocňovať nedá.");
      Console.WriteLine();
  }
}
void Find()
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
void Help()
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
  Console.WriteLine("      - find - nájde zadanú hodnotu v poli a napíše na akej pozícii sa nachádza");
  Console.WriteLine("      - sort - nájde minimálnu hodnotu v poli");
  Console.WriteLine("      - min -oradí pole od najmenšej hodnoty, po najväčšiu");
  Console.WriteLine();
}
void Rect()
{
  Console.WriteLine();
  Console.WriteLine("Rozumiem, robíme operáciu rect.");
  Console.WriteLine();
  Console.Write("Zadaj dĺžku strany a: ");
  if (!int.TryParse(Console.ReadLine(), out int rect_a))
  {
      Console.WriteLine();
      Console.WriteLine("Chyba, neplatné číslo.");
      Console.WriteLine();
      return;
  }
  Console.WriteLine();
  Console.Write("Zadaj dĺžku strany b: ");
  if (!int.TryParse(Console.ReadLine(), out int rect_b))
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
      if (rect_a > 0 && rect_b > 0)
      {
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
              break;
          }
          else
          {
              Console.WriteLine("Chyba, zadaj správny príkaz.");
          }
          Console.WriteLine();
      }
      else
      {
          Console.WriteLine("Zadaj správne údaje.");
      }
  }
}
void Array()
{
   Console.WriteLine();
   Console.WriteLine("Rozumiem, robíme operáciu array.");
   Console.WriteLine();
   Console.Write("Zadaj číselné pole (príklad: 1 0 9 1 2): ");
   int[] pole;
   int rect_a = int.Parse(Console.ReadLine());
   Console.WriteLine();
   Console.Write("Zadaj dĺžku strany b: ");
   int rect_b = int.Parse(Console.ReadLine());
   Console.WriteLine();
   while (true)
   {
       Console.Write($"Rozumiem, máme obdĺžnik v rozmere {rect_a}x{rect_b}, zadaj príkaz (area, perimeter, diagonal): ");
       string prikaz_rect = Console.ReadLine();
       if (rect_a > 0 && rect_b > 0)
       {
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
               break;
               break;
           }
           else
           {
               Console.WriteLine("Chyba, zadaj správny príkaz.");
           }
           Console.WriteLine();
       }
       else
       {
           Console.WriteLine("Zadaj správne údaje.");
       }
   }
}
