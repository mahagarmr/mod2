using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Потрібно передати шлях до файлу та слово для пошуку як аргументи командного рядка.");
            return;
        }

        string filePath = args[0];
        string searchWord = args[1];

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Файл не знайдено.");
            return;
        }

        string fileContent = File.ReadAllText(filePath);

        int count = 0;
        int index = 0;
        while ((index = fileContent.IndexOf(searchWord, index)) != -1)
        {
            count++;
            index += searchWord.Length;
        }

        Console.WriteLine($"Слово '{searchWord}' зустрічається у файлі {count} раз(ів).");

        Console.ReadLine();
    }
}