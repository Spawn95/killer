using System;
using System.Diagnostics;
public void Kill ();



var processes = Process.GetProcesses();
foreach (var process in processes)
    Console.WriteLine($"{nameof(Process.ProcessName)}: {process.ProcessName}, { nameof(Process.Id)} : {process.Id}");

Console.WriteLine("Я вывел процессы которые ты можешь убить:):) указав лишь ID процесса или его название ( указав название ты завершишь всю ветку процесса ).");
Console.WriteLine("Значит вот список, теперь давай выберем, как именно хочешь ты убить процесс.");
Console.WriteLine("1 - Убить процесс по имени(Помни! Данный метод убивает всю ветку ");
Console.WriteLine("2 - убить процесс по ID");
int x = Convert.ToInt16(Console.ReadLine());
try
{

    if (x == 1)
    {

        Console.WriteLine("Укажите корректное название процесса");
        var stage = Process.GetProcessesByName(Convert.ToString(Console.ReadLine()));
        stage.Kill();
    }
    else if (x == 2)
    {
        Console.WriteLine("Укажите ID процесса");
        var stageOne = Process.GetProcessById(Convert.ToInt16(Console.ReadLine()));
        stageOne.Kill();
    }
    else
    {
        Console.WriteLine("Вы ввели некорректные данные");
        return;
    }
}
catch
{
    _ = x != 1 && x != 2;
    Console.WriteLine("Вы ввели некорректные данные");
    return;
}


