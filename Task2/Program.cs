// Задача 2: Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет количество чётных чисел в массиве.

int N = 10;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
a[i]=random.Next(1,101);
for(int i=0;i<a.Length;i++)
System.Console.Write($"{a[i], 4}");

int count=0;
for(int i=0; i < a.Length; i++)
{
if(a[i] % 2 == 0)
count++;
}

System.Console.WriteLine();
System.Console.WriteLine(count);
