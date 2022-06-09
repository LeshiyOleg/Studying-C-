﻿// Перебор слов
// В некотором машинном алфавите имеются четыре
// буквы «а», «и», «с» и «в». Покажите все слова,
// состоящие из T букв, которые можно построить из букв
// этого алфавита

char[] s = { 'а', 'и', 'с' };
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        for (int k = 0; k < count; k++)
        {
            Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}");
        }
    }
}

void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("дота", new char[4]);