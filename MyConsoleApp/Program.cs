/**
 Lab 1: Console and GUI Application in .NET 

 OBJECTIVE: 
 - To create and run a basic .NET console application. 
 - To create and run basic .NET GUI applicaiton with a buttons and labels. 

 THEORY: 
 - What is .NET? 
 - Explain features of .NET. 
 - Difference between GUI and console application 

 CODE : 
 1. To create new console applicaiton: 
   dotent new console -n MyConsoleApplication
 2. Build : dotnet build 
 3. Run : dotnet run 

 4. To create a winform: 
 >> dotnet new winforms -n MyWindowApp
**/


using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World !!!");
    }
}