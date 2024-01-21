using System;

class Program
{
    static void Main()
    {
        string[] исходныйМассив = { "Hello", "2", "world", ":-)", "qwerty" };
        

        string[] новыйМассив = ФильтроватьПоДлине(исходныйМассив, 3);

        Console.WriteLine("Исходный массив: " + string.Join(", ", исходныйМассив));
        Console.WriteLine("Новый массив: " + string.Join(", ", новыйМассив));

        Console.ReadLine();
    }

    static string[] ФильтроватьПоДлине(string[] исходныйМассив, int максимальнаяДлина)
    {
        int новаяДлина = 0;
        for (int i = 0; i < исходныйМассив.Length; i++)
        {
            if (исходныйМассив[i].Length <= максимальнаяДлина)
            {
                новаяДлина++;
            }
        }

        string[] новыйМассив = new string[новаяДлина];
        int индексНовогоМассива = 0;
        for (int i = 0; i < исходныйМассив.Length; i++)
        {
            if (исходныйМассив[i].Length <= максимальнаяДлина)
            {
                новыйМассив[индексНовогоМассива] = исходныйМассив[i];
                индексНовогоМассива++;
            }
        }

        return новыйМассив;
    }
}