//8. Показать четные числа от 1 до N
System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int[] array = new int[number];
int cifr1 = 1;
for(int i = 0; i < array.Length; i++ )
{
    array [i] = cifr1;
    System.Console.Write(array[i]); 
    cifr1 += 1;
}