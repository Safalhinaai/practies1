using Microsoft.VisualBasic;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)

            
        {
            //first class in C# programming

            //string declaration
            string MyName = "safa";
            int MyAge = 27;
            Console.WriteLine("Hello my name: " + MyName +   "My age is "  + MyAge
               );
            
            //we use this statement to print an output
            Console.WriteLine();
            //example
            Console.WriteLine("Hello world!");

            //variable type in C#
            //int - stores integers
            int myNum = 150;
            //double - stores floating point numbers
            double myDoubleNum = 5.99D;
            //char - stores single characters
            char myLetter = 'D';
            //string -stores text
            string MyName = "safa";
            //bool - stores values with two states: true or false
            bool myBool = true;


            //create get hash code
            int A1 = 10;
            Console.WriteLine(A1.GetHashCode());

            int A2 = 20;
            Console.WriteLine(A2.GetHashCode());

            //create 2 object
            Object obj1= new Object();
            Object obj2 = new Object();
            Console.WriteLine(obj1.GetType());

            //string concatenation
            Console.WriteLine($"name : {MyName} " + $"age : {MyAge}");

            //comparison operation
            int x = 5;
            int y = 10;
            //equall operation
            bool equal =x == y; // false
            //not equal operation
            bool notEqual=x != y; // true
            //less than operation
            bool lessThan =x < y; // true


            Console.WriteLine(equal); 
            Console.WriteLine(notEqual);
            Console.WriteLine(lessThan);


            //xor logical operation: if the input both same the output will be false, ^ used operator computes the logical exclusive
            Console.WriteLine(true ^ true);    // output: False
            Console.WriteLine(true ^ false);   // output: True
            Console.WriteLine(false ^ true);   // output: True
            Console.WriteLine(false ^ false);  // output: False











        }
    }
}