
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
                Console.WriteLine(num+" ");
            }
            
        }
    }
    // single dimentation array 

    


}
    

