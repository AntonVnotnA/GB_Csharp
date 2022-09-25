Console.WriteLine("Please print an user name.");
string username = Console.ReadLine();

if (username.ToLower() == "anton")
{
    Console.WriteLine("We are happy to see you Anton!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}