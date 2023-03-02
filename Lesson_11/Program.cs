//11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
System.Console.WriteLine("Задайте число: ");
int number = int.Parse(Console.ReadLine());
int numberA = number / 10;
int numberB = number %10;
if(numberA < numberB)
{
    System.Console.WriteLine($"{numberB}");
}
else
{
   System.Console.WriteLine($"{numberA}"); 
}