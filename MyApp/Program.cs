// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Зміна
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        GreetUser("User");
    }

    static void GreetUser(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}

