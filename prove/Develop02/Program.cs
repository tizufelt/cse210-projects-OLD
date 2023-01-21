using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
    }
}

class writeNRead //write and read into journal files


class saveNLoad // load and save texxt file


class prompt // prompt and display
variables:
private static bool MainMenu() { Console.Clear(); 
Console.WriteLine("Choose an option:"); 
Console.WriteLine("1) Reverse String"); 
Console.WriteLine("2) Remove Whitespace"); 
Console.WriteLine("3) Exit"); 
Console.Write("\r\nSelect an option: "); 
switch (Console.ReadLine()) { case "1": ReverseString(); 
return true; 
case "2": RemoveWhitespace(); 
return true; 
case "3": return false; 
default: return true; } }