System.Console.WriteLine("Введите размер массива: ");
int massa = Convert.ToInt32(Console.ReadLine());
int[]array = new int [massa];
int sum = 0;

for(int i = 0; i < array.Length; i++)
{
System.Console.Write($"Введите элемент массива под индексом {i}: ");
 array[i]= Convert.ToInt32(Console.ReadLine());
}

for (int i = 1; i < array.Length; i += 2)
  {
    sum += array[i];
  }
System.Console.WriteLine($"Сумма чисел чётных индексов: {sum}");

