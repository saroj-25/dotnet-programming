/**

LAB 2: 
TITLE: BASICS OF C# 

OBJECTIVE: 
1) To understand and use valid indentifiers in c# 
2) To write single line and multiline comments in c#
3) To declare and use different datatypes like int, float, chat, string and bool 
4) To create expression using arithmetic, relation,logical, and assignment operators 
5) To declare, manipulate and perform operations in string and char type

THEORY: 

1) Identifiers: 

- Identifiers are the valid name given to the varibales, methods, or other elements. They are defined by users in a program. 

- Rules for Idenfiers: 
    - Must start with letter(a-z or A-Z) or underscore. 
    - Cannot start with digits. 
    - Digits can be places after starting from letters i.e 0-9
    - Cannot contain C# reserved keywords (for e.g. int, pubic, if, else, class, interface)
    - It is case sensative (myVar and myvar are different) 
    - Should be meaningful and follow either cases: 
        - Camel case: myNumber, currentContext
        - Pascle case: MyNumber, CurrentContext 
        - Snake case: my_number, current_context
    
    [Note: there are 79 reserved words in c#]

2) Comments: 
    - They are non-executable codes usde for debugging, explaining the code. 
    - They are of two types: 
    1) Single line comment: 
        - They are written in single line starting with // 
        >> // This is single line comment 
        >> int age = 25 //declaring age variable 
        
    2) Multiline comment: 
        - They are written in multiple lines with * and /  
        - example: We are writing in multiline comment

3) Data types in C#: 
    - It is defined as the type of data(values) that a variable can hold. 
    - C# is strongly typed programming language because we must declare a variable type before using it. 

    - Some of the data types in C# are: 
        1) Integer: 
          - Represent as : int 
          - Size : 4 bytes 
          - Example: >> int age = 25;
        2) float: 
          - Represented as : float 
          - Size: 4 bytes 
          - Example: >> float pi = 3.14; 
        3) double: 
          - Represnted as : double 
          - Size : 8 bytes 
          - double g = 9.8
        4) Character: 
            - Represented as : char 
            - 2 bytes 
            - char grade = 'A'; 
            - ASCII(Americal Standerd code for infromation interchange): 
                a - 97
                A - 65
        5) String: 
            - represented as : string
            - String are the sequence of characters ending with \0
            - Size: Variable 
            - example: >> string name = "Kritika";
        6) Boolean: 
            - represented as : bool
            - Size = 1 byte 
            - example: >> bool isPassed = true; 

4) Expression and operators: 
    a) Expressions: 
        - Expressions are combination of variables, values and operators used to produce a result. 
        - For example: 
        >> int a = 20; 
        >> int b = 30; 
        >> int sum = a+b;

    b) Operators: 
        - Operators are sybools used to perform an operation between two or more operands(variables). 
        - Types of operators: 

        1) Arithmetic operators: 
            - They are the type of operators used to compute mathematical operations. 
            - For eg: +, -, *, /, %

        2) Relational operators: 
            - They are the type of operators used to compare between two operands. 
            - It gives boolean value as a result. 
            - eg, ==, <= , >= , != , >, < 

        3) Logical operators: 
            - They are the type of operators used to operate with the mulitple conditions. 
            - &&(AND), ||(OR), !(Not)

        4) Assignment operators: 
            - They are the type of operators used to assign a value to the variable 
            -  =, += , -= , *=, /=, %= 

            >> int age = 10 ;
            >> age+=10; // age = age+10; 

        5) String in C#: 
         - It is the combination of sequence of characters terminated by '\0'. 
         - char fistLetter = 'p';

         string firstName = "puja";

**/

using System;


namespace BasicsOfCSharp.Basics
{
    class CSharpBasics
    {
        public void FirstProgram()
        {
            // idefiers and keywords 

            int studentAge = 20; 
            const double pi = 3.14; 

            // writing multiline comment 

            /**
             This is multi line comment    
            **/


            Console.WriteLine("\n ==== Data Types in C# === ");
            int number = 10;
            float percentage = 75.5f;
            char grade = 'A';
            string name = "John Doe";
            bool isPassed = true;

            // Displaying the data types
            Console.WriteLine($"Integer: {number}");
            Console.WriteLine($"Float: {percentage}");
            Console.WriteLine($"Char: {grade}");
            Console.WriteLine($"String: {name}");
            Console.WriteLine($"Boolean: {isPassed}");

            Console.WriteLine("\n ==== Operators and Expression in C# === ");

            Console.WriteLine("\n Expression and operators in C#");

            int a = 20 , b = 30; 

            //arithmetic operators 
            Console.WriteLine($"\n Addition : {a+b}");
            Console.WriteLine($"\n Subtraction : {a-b}");
            Console.WriteLine($"\n Multiplication : {a*b}");
            Console.WriteLine($"\n Division : {a/b}");
            Console.WriteLine($"\n Modulus : {a%b}");

            //relational operators 
            Console.WriteLine($"\n Is a greater than b : {a>b}");
            Console.WriteLine($"\n Is a less than b : {a<b}");
            Console.WriteLine($"\n Is a less than or equal to b : {a<=b}");
            Console.WriteLine($"\n Is a greater than or equal to b : {a>=b}");

            //logical operator 

            bool isCitizen = true; 
            int age = 30;

            //logical and operator 
            if(isCitizen && age >= 18)
            {
                Console.WriteLine("\n Is elisible to vote");
            }

            else
            {
                Console.WriteLine("\n Is not elisible to vote");
                
            }

            //or operator 

            bool hasCitizenship = true; 
            bool hasLiscense = false; 
            bool hasNID = false; 

            if(hasCitizenship || hasLiscense || hasNID)
            {
                Console.WriteLine("\n Identification verified");
                
            }
            else
            {
                Console.WriteLine("\n You need national identity documents.");     
            }


            // assignment operator 
            a+=10;
            Console.WriteLine(a); 


            //String handling in C# 
            char firstLetter = 'P'; 
            Console.WriteLine($"The char is: {firstLetter} ");

            // string 
            string firstName = "Pratistha";
            string lastName = "Bhandari";

            //string concatenation 
            string fullName = firstName + " " + lastName; 

            Console.WriteLine($"Welcome to C# class {fullName}");

            //common string methds 

            string message = "Hello BCA 5th sem Aadim college"; 
            Console.WriteLine(message);

            //upper case 
            Console.WriteLine(message.ToUpper());

            //lower case 
            Console.WriteLine(message.ToLower());

            //contaion 
            Console.WriteLine(message.Contains("Aadim"));// result in true false

            //replace
            Console.WriteLine(message.Replace("Aadim", "TU"));// result in true false


            //string interpolation 
            long phoneNo = 9812345678;
            Console.WriteLine("Enter your name: \n"); 
            string userName = Console.ReadLine()??"";

            Console.WriteLine($"Welcome {userName} !! with Contact {phoneNo}");


            //escape sequence 

            Console.Write("Pemba \n"); 
            Console.Write("Sherpa"); 

            





            











            
            










        }
        
    }
}