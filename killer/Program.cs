using System;
using System.Diagnostics;



var processes = Process.GetProcesses();
foreach (var process in processes)
    Console.WriteLine($"{nameof(Process.ProcessName)}: {process.ProcessName}, { nameof(Process.Id)}: {process.Id}");

Console.WriteLine("Я вывел процессы которые ты можешь убить:):) указав лишь ID процесса или его название ( указав название ты завершишь всю ветку процесса ).");
Console.WriteLine("Значит вот список, теперь давай выберем, как именно хочешь ты убить процесс.");
Console.WriteLine("1 - Убить процесс по имени(Помни! Данный метод убивает всю ветку )");
Console.WriteLine("2 - убить процесс по ID");
int x = Convert.ToInt16(Console.ReadLine());
 if (x == 1 || x == 2)
{
    try
    {
        if (x == 1)
        {
            Console.WriteLine("Укажите корректное название процесса");
            string stage = Console.ReadLine();
            foreach (Process process in Process.GetProcessesByName(stage))
                process.Kill();
        }
        else if (x == 2)
        {
            Console.WriteLine("Укажите ID процесса");
            var stageOne = Process.GetProcessById(Convert.ToInt16(Console.ReadLine()));
            stageOne.Kill();
        }
        else
        {
            Console.WriteLine("Вы ввели некорректные данные.");
            return;
        }
    }
    catch
    {
        _ = x != 1 && x != 2;
        Console.WriteLine("Данные были введены некорректно.");
        return;
    }
} else
    Console.WriteLine("Нужно указать 1 или 2");
Console.ReadLine();


