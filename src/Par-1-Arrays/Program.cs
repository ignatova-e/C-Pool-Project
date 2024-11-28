using System;

class Program
{
    static void Main()
    {

        Console.Write("Введите сколько элементов будет в массиве: ");
        int size = Convert.ToInt32(Console.ReadLine()); // Определение количество элементов в массивве
        int counter = 0;
        int[] array = new int[size];

        while (counter != size) // Запись массива
        {
            Console.Write("Введите значение для " + (counter + 1)
            + " элемента массива: ");
            array[counter] = Convert.ToInt32(Console.ReadLine());
            counter++;
        }

        minValue(array, size);
        maxValue(array, size);
        averageValue(array, size);
        sumValue(array, size);

    }

    static void minValue(int[] array, int size) // Нахождение минимального значения массива
    {
        int minimum = array[0];
        for (int i = 0; i < size; i++)
        {
            if (array[i] < minimum)
            {
                minimum = array[i];
            }
        }
        Console.Write("Минимальное значение массива: ");
        Console.WriteLine(minimum);
    }

    static void maxValue(int[] array, int size) // Нахождение максимального значения массива
    {
        int maximum = array[0];
        for (int i = 0; i < size; i++)
        {
            if (array[i] > maximum)
            {
                maximum = array[i];
            }
        }
        Console.Write("Максимальное значение массива: ");
        Console.WriteLine(maximum);
    }

    static void averageValue(int[] array, int size) // Нахождение среднего значения массива
    {
        int average = 0;
        for (int i = 0; i < size; i++)
        {
            average += array[i];
        }
        float result = Convert.ToSingle(average) / size;
        Console.WriteLine("Среднее значение массива: " + result);
    }

    static void sumValue(int[] array, int size) // Нахождение суммы всех элементов массива
    {
        int sum = 0;
        for (int i = 0; i < size; i++)
        {
            sum += array[i];
        }
        Console.WriteLine("Сумма всех элементов массива: " + sum);
    }

}

