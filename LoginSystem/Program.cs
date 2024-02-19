// See https://aka.ms/new-console-template for more information
using LoginSystem;
Console.WriteLine("*** Welcome to Login System ***");
try {
  
    Console.WriteLine("Enter UserName:");
    string username = Console.ReadLine();
    Console.WriteLine("Enter Password :");
    string password = Console.ReadLine();
    Authentication auth = new Authentication();
    Console.WriteLine(auth.LogIn(username, password));
}
catch(Exception e) { Console.WriteLine(e.Message); }
