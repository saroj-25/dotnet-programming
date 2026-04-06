using System.Xml;

namespace Dotnet.Statemnts
{

    class Statemnts
    {
        public void ShowStatemnts()
        {
            // declaration and expression 


            int number = 5; 
            string name = "Norbu"; 
            double price = 10.99; 


            number = number + 2; 
            price = price + 30.33; 

            //selection statement (if-else ,switch case )

            Console.WriteLine("Name: " + name); 
            Console.WriteLine("Price"+ price); 
            Console.WriteLine("Number"+number);
            Console.WriteLine("Price"+price);

            Console.WriteLine("Enter any number");
            int input = Convert.ToInt32(Console.ReadLine());

            //if-else statemet 

            if(input>0)
            {
                Console.WriteLine("Positive number"); 
            }
            else if(input<0)
            {
                Console.WriteLine("Negative number");
            }

            else
            {
                Console.WriteLine("The number is zero");
            }

            // switch case 
            // TODO : Take input as traffic light symbools(R, G, Y) and use switch case to display the message 

            Console.WriteLine("Enter a light (R,G,Y)");
            string? color = Console.ReadLine(); 

            switch(color)
            {
                case "R":
                    Console.WriteLine("Traffic light is red stop");
                    break; 
                 case "G":
                    Console.WriteLine("Traffic light is red Go");
                    break; 
                 case "Y":
                    Console.WriteLine("Traffic light is yellow Be Ready");
                    break; 
                 default:
                    Console.WriteLine("Invalid input");
                    break;
                
            }


            //looping control statement 
            while(condition)
            {
                
            }

            do
            {
                
            }while(condition);

            for(dec , testcondition, updation))
            {
                
            }






            
        }
    }
    

}