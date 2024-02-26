// See https://aka.ms/new-console-template for more information
using ConsoleAppDay05Docker;

Console.WriteLine("Hello, World!");
try
{
    Console.WriteLine("Enter UserName");
    string username = Console.ReadLine();
    Console.WriteLine("Enter Password");
    string password = Console.ReadLine();
    Auth auth = new Auth();
    Console.WriteLine(auth.Login(username, password));
}
catch(Exception ex)
{
    Console.WriteLine("Error " + ex);
}


Console.WriteLine("Enter a Number");
int lnum = int.Parse(Console.ReadLine());
OurNumbers.Counting(lnum);

Console.WriteLine("Enter a Number for Table");
int tnum = int.Parse(Console.ReadLine());
OurNumbers.Tables(tnum);

