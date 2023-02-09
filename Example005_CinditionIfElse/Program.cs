Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "зарема")
{
    Console.WriteLine("Ура, это же ЗАРЕМА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
