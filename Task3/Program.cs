// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.


double[] a = new double[10];
double N = 0;
Random random = new Random();
for (int i = 0; i < a.Length; i++)
{N = random.Next(1,10000);
a[i] = N/100;}

for (int i = 0; i < a.Length; i++)
{
   
   Console.Write($"{a[i],6}");
   Console.WriteLine();
}

double min = a[0];
double max = a[0];

{
    for (int i = 0; i < a.Length; i++)
{
    if (a[i] > max)
        {
            max = a[i];
        }
    if (a[i] < min)
        {
            min = a[i];
        }

}

double difference = max - min;
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным значением = {difference}");

}