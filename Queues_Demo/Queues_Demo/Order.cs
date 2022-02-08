using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_Demo
{
    class Order
    {
        //orderID
        public int OrderID{ get; set; }

        //orderQuantity
        public int OrderQuantity { get; set; }

        //simple constructor
        public Order(int id, int orderQuantity)
        {
            this.OrderID = id;
            this.OrderQuantity = orderQuantity;
        }

        //pring message on the screen that the order was processed
        public void ProcessOrder()
        {
            Console.WriteLine($"Order {OrderID} processed successfully!");
        }
    }
}
