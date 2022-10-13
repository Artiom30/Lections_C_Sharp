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

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
/*
string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"    Помещаем текст в переменную типа string
//             012345     и всесимволы в строке нумеруется как массив
// s[3]  это r  s[0] это q  - это способ обращения к нумерованому симвалу


// Создадим метод строчного типа с тремя переменными:
// 1 сам текст . 2 Символ в тексте. 3 Тот символ на каторый будем менять
string Replace(string text, char oldValue, char newValue)
//char - тип переменной , конкретный символ.
{
    string result = String.Empty; // Задаём переменную с пустой строкой

    int length = text.Length;     // "измерим" количество символов в тексте(строке).
    for (int i = 0; i < length; i++) // Пробегаем счётчиком по строке...
    {   // Если текущий символ в строке совпадёт с заданным
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";  // не понятно как это работает...
    }

    return result;
}
string newText = Replace(text, ' ', '|');
// Обращения к переменным типа char - производятся символоми  '' .
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace(text, 'с', 'С');
Console.WriteLine(newText);
*/

