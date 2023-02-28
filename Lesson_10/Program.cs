//7. Показать числа от -N до N
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[]array = new int[(number*2)+1];
for(int i = number*2; i >= 0 ; i--)
   {
    array[i] = number;
   number-=1;
   System.Console.WriteLine(array[i]);
   }