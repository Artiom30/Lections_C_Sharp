// Задача 4: Перебор слов 
//           В некотором машинном алфавите имеются четыре
//           буквы «а», «и», «с» и «в». Покажите все слова,
//           состоящие из T букв, которые можно построить из букв
//           этого алфавита

// Итеративный метод:
char[] s = { 'а', 'и', 'с', 'в' };
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    Console.WriteLine($"{n++,-5}{s[i]}");
}


// Рекурсивный метод: