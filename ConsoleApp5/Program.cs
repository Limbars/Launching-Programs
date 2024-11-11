using System.Diagnostics;
using System;
using System.IO;

string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
string fileName = "list_applications.txt";
string path = Path.Combine(directoryPath, fileName);

string text = "";

try
{
    using (StreamReader sr = new StreamReader(path))
    {
        text = sr.ReadToEnd(); // Читаем весь текст из файла
    }

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


