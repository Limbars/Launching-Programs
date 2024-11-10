using System.Diagnostics;
using System;
using System.IO;

string path = @"C:\Users\Limbars\source\repos\ConsoleApp5\ConsoleApp5\list_applications.txt"; //требуется указать свой путь, у вас он может отличаться
string text = "";

try
{
    using (StreamReader sr = new StreamReader(path))
    {
        text = sr.ReadToEnd(); // Читаем весь текст из файла
    }

    // Разделяем текст на строки
    string[] lines = text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

    for (int i = 0; i < lines.Length; i++)
    {
        string applicationPath = lines[i].Trim(); // Убираем лишние пробелы
        if (!string.IsNullOrEmpty(applicationPath)) // Проверяем, что строка не пустая
        {
            Process.Start(applicationPath);
        }
    }
}
catch (Exception e)
{
    Console.WriteLine($"Ошибка: {e.Message}");
}


