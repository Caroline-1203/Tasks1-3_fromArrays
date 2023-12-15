// // Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр.

    Console.WriteLine("Напишите число от 1 до 100 000: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int length = 0;
    int digit = 1;
        
    // Cчитаем колличество цифр
    for (int i = 0; i < 7; i++)
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



