Console.Write("Введите имя пользователя : ");
string username = Console.ReadLine();
if(username.ToLower() == "диана")
{
Console.WriteLine("Ура! Это Диана!!!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}