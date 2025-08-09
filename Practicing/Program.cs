// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is your name?");
var name = Console.ReadLine();
Console.WriteLine("How old are you?");
int age = int.Parse(Console.ReadLine());

int yearsUntil100 = 100 - age;

Console.WriteLine($"{name}, you will turn 100 in {yearsUntil100} years."); 
