//13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
System.Console.WriteLine("Задайте число: ");
int numberA = int.Parse(Console.ReadLine());
System.Console.WriteLine("Задайте число для проверки: ");
int numberB = int.Parse(Console.ReadLine());

int res = numberA % numberB;
if (res == 0)
{
    System.Console.WriteLine($"Число {numberA} кратно {numberB}");
}
else
{
    System.Console.WriteLine($"{res}");
}