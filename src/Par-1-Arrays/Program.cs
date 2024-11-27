using System;

class Program
{
    static void Main()
    {

        // int? size = int.Parse(Console.ReadLine());
        Console.Write("Введите сколько элементов будет в массиве: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int counter = 0;
        int[] array = new int[size];

        while (counter != size)
        {
            Console.Write("Введите значение для " + (counter + 1)
            + " элемента массива: ");
            array[counter] = Convert.ToInt32(Console.ReadLine());
            counter++;
        }


        int i = 0;
        while (i != size)
        {
            Console.WriteLine(array[i]);
            i++;
        }
    }
}

