//9. Показать последнюю цифру трёхзначного числа
System.Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{number %10} Последняя цифра");