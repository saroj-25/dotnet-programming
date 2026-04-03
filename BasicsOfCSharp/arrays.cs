
/**

TITLE: Arrays in C# 

OBJECTIVE: 
- To declare, intialize, and store multiple values in a single array of same type. 
- To retrieve, update and loop through the elements in an array 
- To implement 2D and 3D arrays in C# 
- To implement Jagged arrays(array of arrays) in c# 

THEORY: 

Arrays: 

Arrays is defined as a static linear data structure where elements are stored in contigious memory location. 
- In array there is an index which makes data retrieval faster. 
- The value of index of an array ranges from 0 to n-1 where n is the size of an array. 

Jagged Arrays: 
- A jagged array is an array of arrays, where each element is itself an array that can have a different length. Rows are fixed at declaration, but columns can vary. It can also combine with multidimensional arrays.

**/

namespace BasicsOfCSharp.Arrays
{
    using System; 

class Arrays
{
   
        public void SecondProgram()
        {
            int[] numbers = {10,20,30,40,50};

            Console.WriteLine("Elements in array");

            foreach (int num in numbers)
            {
                Console.Write(num+" ");
            }

            Console.WriteLine();

            //displaying single element 
            Console.WriteLine("Element on 3rd Index of an array: "+numbers[3]);

            string[] students = {"Pratistha", "Pratigya", "Puja", "Pema", "Pemba"};
            Console.WriteLine();
            Console.WriteLine("Students array: ");
            //display 
            foreach(string student in students)
            {
                Console.Write(student + " ");
            }


            // modification of elments in an array 

            students[4] = "Prerana";
            Console.WriteLine("String array after modification:");
            foreach(string student in students)
            {
                Console.Write(student + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"Total elemnts in an student array is {students.Length}");

            // searching elements in an array 
            string searchStudent = "Pratigya";
            int position = Array.IndexOf(students, searchStudent);

            if(position != -1)
            {
                Console.WriteLine($"{searchStudent} found at {position} index");
            }
            else
            {
                Console.WriteLine($"{searchStudent}  not found at any index");
                
            }

            //sorting elements in an array 
            Array.Sort(students);

            Console.WriteLine("Elements after sorting :"); 
            foreach(string student in students)
            {
                Console.Write(student + " ");
            }

            // advance arrays 

            int [,] matrix = {{1,2,3},{4,5,6},{7,8,9}};

            //display 
            Console.WriteLine("2D array:");

            for(int i = 0; i< matrix.GetLength(0);i++)
            {
                for(int j =0; j< matrix.GetLength(1);j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }






            
        }
    }
    // single dimentation array 

    

    


}
    

