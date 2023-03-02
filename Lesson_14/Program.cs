//14. Найти третью цифру числа или сообщить, что её нет
System.Console.WriteLine("Задайте число для проверки: ");
int cifr = int.Parse(Console.ReadLine());

if (cifr / 100 == 0)
{
      System.Console.WriteLine($"У числа {cifr} нет третьей цифры.");
}
else
{
    while ( cifr > 1000 ) cifr = cifr /10;      
      int res = cifr % 10;
      System.Console.WriteLine($"Третья цифра числа {res}");
}