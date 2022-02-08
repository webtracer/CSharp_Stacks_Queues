using System;
using System.Collections.Generic;

namespace Queues_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // defining a queue of integers
            Queue<int> myFirstQueue = new Queue<int>();
            myFirstQueue.Enqueue(1);

            Console.WriteLine($"The value at the front of the queue is {myFirstQueue.Peek()}");
            Console.WriteLine("");
            int start = myFirstQueue.Peek();
            for(int count = 0; count < 10; count++)
            {
                int queuedNumber = start += count + 1 * 2;
                myFirstQueue.Enqueue(queuedNumber);
                Console.WriteLine($"Just added the number {queuedNumber} to the queue");
                Console.WriteLine($"In the FOR loop the value at the front of the queue is {myFirstQueue.Peek()}");
                Console.WriteLine($"The number of items in myFirstQueue is {myFirstQueue.Count}");
            }
            Console.WriteLine("");
            Console.WriteLine($"After the FOR loop the value at the front of the queue is {myFirstQueue.Peek()}");

            while (myFirstQueue.Count > 0)
            {
                Console.WriteLine($"The current queue count of myFirstQueue is {myFirstQueue.Count}");
                Console.WriteLine($"The number that was dequeued is {myFirstQueue.Dequeue()}");
                if (myFirstQueue.Count != 0)
                {
                    Console.WriteLine($"After the Dequeue the value at the front of the queue is {myFirstQueue.Peek()}");
                }
                else { Console.WriteLine("There are no more items in myFirstQueue"); }
            }

            //create a queue of Orders from the Class Order (not an int or a string)
            Queue<Order> ordersQueue = new Queue<Order>();

            foreach(Order o in ReceiveOrdersFromBranch1())
            {
                //add each order to the queue
                ordersQueue.Enqueue(o);
            }

            foreach (Order o in ReceiveOrdersFromBranch2())
            {
                //add each order to the queue
                ordersQueue.Enqueue(o);
            }

            foreach(Order i in ordersQueue)
            {
                Console.WriteLine($"The order number is: {i.OrderID}");
            }

            while(ordersQueue.Count < 0)
            {
                // remove the order at the front of the queue
                // store it in a variable called currentOrder
                Order currentOrder = ordersQueue.Dequeue();
                //process the order
                currentOrder.ProcessOrder();
            }

            static Order[] ReceiveOrdersFromBranch1()
            {
                //creating new orders array
                Order[] orders = new Order[]
                {
                    new Order(1,5),
                    new Order(2,4),
                    new Order(6,10)
                };
                return orders;
            }

            static Order[] ReceiveOrdersFromBranch2()
            {
                //creating new orders array
                Order[] orders = new Order[]
                {
                    new Order(3,5),
                    new Order(4,4),
                    new Order(5,10)
                };
                return orders;
            }
        }
    }
}
