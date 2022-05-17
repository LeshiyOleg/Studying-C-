// Виды методов с примерами

// Type 1
void Method1()
{
    Console.WriteLine("Автор Олег");
}
//Method1();

// Type 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Сообщение Метода 2");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}
//Method21("Сообщение Метода 21", 4); //как вариант
//Method21(msg: "Сообщение Метода 21", count: 4); // тоже как вараинт
//Method21(count: 4, msg: "Сообщение Метода 21");


//Type 3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);


//Type 4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z ");
Console.WriteLine (res);