using System;
using System.Collections.Generic;

namespace Stacks_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // defining a new stack
            Stack<int> myStack = new Stack<int>();
            //Add elements to the stack using Push()
            myStack.Push(1);
            //Peek() will return the element at the top of the stack without removing it
            Console.WriteLine($"Top value in myStack is:  {myStack.Peek()}");

            myStack.Push(314);
            Console.WriteLine($"Top value in myStack is:  {myStack.Peek()}");

            myStack.Push(228);
            Console.WriteLine($"Top value in myStack is:  {myStack.Peek()}");

            myStack.Push(98762314);
            Console.WriteLine($"Top value in myStack is:  {myStack.Peek()}");

            myStack.Push(982314);
            Console.WriteLine($"Top value in myStack is:  {myStack.Peek()}");

            myStack.Push(98764);
            Console.WriteLine($"Top value in myStack is:  {myStack.Peek()}");

            myStack.Push(9876);
            Console.WriteLine($"Top value in myStack is:  {myStack.Peek()}");

            int myStackTop = myStack.Pop();

            Console.WriteLine($"Top value in myStack is now:  {myStack.Peek()}");
            Console.WriteLine($"The item I popped off the top of the stack is: {myStackTop}");

            Console.WriteLine($"Stack count before the while loop is {myStack.Count}");
            while(myStack.Count != 0)
            {
                Console.WriteLine($"Now popping off the top value of {myStack.Pop()}");
                Console.WriteLine($"The stack count is now {myStack.Count}");
            }

            Console.WriteLine($"There are now {myStack.Count} items in the stack myStack");

            //reverse the numbers in the array in a stack
            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };
            Stack<int> myNumbers = new Stack<int>();

            Console.WriteLine($"The numbers array reads {String.Join(",", numbers)}");

            foreach(int num in numbers)
            {
                myNumbers.Push(num);
            }

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = myNumbers.Pop();
            }

            Console.WriteLine($"Now the numbers array reads {String.Join(",", numbers)}");

            Console.WriteLine("Hello World!");
        }
    }
}
