﻿// Виды методов

// Вид 1: (void)
// Не берут в себя аргументы и не возвращают никаких аргументов. 
// {
//     Console.WriteLine();
//     Console.WriteLine("Author - Mezheynikov Artiom.");
//     Console.WriteLine();
// }

// Author();

// Вид 2: (void)
// Не возвращают аргументов но берут в себя какой либо аргумент.

// void Unnamed (string message)
// {
//     Console.WriteLine(message);
// }
// Unnamed("Текст сообщения..."); // Не именованные аргументы 
/*
void Named (string message, int count)
{
    int i = 0;
    while (i < count) // Используем цикл для отправки нескольких сообщений 
    {
        Console.WriteLine(message);
        i++; // Уведичение счётчика называют "ИНКРИМЕНТ".
             // Уменьшение счётчика i-- "ДЕКРИМЕНТ".
    }
}
// Именованые аргументы :
Named(message:"Текст",count: 4); 
// Обращаемся к каждому из аргументов по имени в таком виде.
Named(count: 4, message:"Новый текст");
// Последовательность агрументов в таком виде записи не важна.
*/

// Вид 3:(return)
// Возвращаемые методы

// int Data()    // указываем соответствующий тип данных в методе.
// // Аргументы метод не принимает.
// {
//     return DateTime.Now.Year; // для возврата результата работы метода.
// }

// int year = Data();
// Console.WriteLine(year);
// Для обращения к методу выделяем для него переменную, так как он 
// возвращает данные.


// Вид 4: (return)
// Берут в себя и возвращают аргументы.

// string Method4(int count, string text)
// // Строку "text" будем друг за другом компоновать
// // "count" раз.
// {
//     int i = 0;
//     string result = String.Empty; // пустая строка

//     while (i < count)
//     {
//         result = result + text; // В пуструю строку ложим текст 
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "Текст.");
// // Выделяем для результата переменную ,а в аргументах к методу
// // указываем количество раз , которое необходимо написать текст
// // и сам текст.
// Console.WriteLine(res);


// ЦИКЛ for:

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//         result = result + text;
//     return result;
// }
// string res = Method4(10, "Текст.");
// Console.WriteLine(res);

// Цикл в цикле. Таблица умножения.
/*
for (int i = 2; i <= 10; i++)   // int i = 2 - таблица умножения начинается с цифры 2
{
    for (int j = 2; j <= 10; j++)    // Во "внутреннем" цикле в качестве обозначения
    {                                // счётчика используем "j".
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine(); // Это пустая строка. для разделения колонок таблицы
    // Это работает так: после того как внутренний цикл отработает (перемножит
    // все текущие J с одним текущим i , из внешнего цикла) Затем пишется пустая
    // строка и внешний цикл переходит на следующий i и внутренний цикл запускается вновь.
}
*/
