using System;

class Program
{
    static void Main()
    {
        Console.Write("Please text a few words :)  ");
        string? newList = Console.ReadLine(); // Строка содержащая слова
        if (newList == null)
        {
            Console.WriteLine("You are silly");
        }
        else
        {
            string[] words = newList.Split(' '); // Строка разбита на массив слов
            Array.Sort(words);  // Сортиоровка слов по убыванию
            int count = words.Length;
            for (int i = 0; i < count - 1; i++)
            {
                if (i == i + 1)
                {
                    Console.WriteLine(words[i]);
                    i += 2;
                }
                else
                {
                    Console.WriteLine(words[i]);
                    i++;
                }
            }
            // foreach (string word in words)
            // {
            //     Console.WriteLine(word); // Проверка: вывод массива слов
            // }
        }
    }
}