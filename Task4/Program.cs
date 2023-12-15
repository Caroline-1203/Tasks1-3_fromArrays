// // Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр.

//Ввод числа
Console.WriteLine("Напишите число от 1 до 100 000: ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number < 1) | (number > 100000))
{
    System.Console.WriteLine("Число введено некорректно. ");
    return;
}

// Cчитаем колличество цифр
int length = 0;
int digit = 1;
int maxlength = 6;
for (int i = 0; i <= maxlength; i++)
{
    if (number / digit >= 1)
        length++;
    digit *= 10;
}

//Создаем массив 
int[] array = new int[length];

//Заполняем массив
for (int i = array.Length - 1; i >= 0; i--)
{
    array[i] = number % 10;
    number /= 10;
}

// Вывод массива
for (int i = 0; i < length; i++)
    Console.Write($"{array[i],4}");



