//12. Удалить вторую цифру трёхзначного числа
System.Console.WriteLine("Задайте число: ");
int number = int.Parse(Console.ReadLine());

int numberA = number / 100;
int numberB = number %10;
int res = numberA * 10 + numberB;

System.Console.WriteLine($"{res}");