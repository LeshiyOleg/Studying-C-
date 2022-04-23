//Особое приветствие любимчика
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "олег")
{
    Console.WriteLine("Ура, это ж ОЛЕДЖИО!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}