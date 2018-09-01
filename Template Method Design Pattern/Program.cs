using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template_Method_Design_Pattern.Basic;

namespace Template_Method_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sending order UPS:");
            OrderShipment upsOrder = new UpsOrderShipment();
            upsOrder.ShippingAddress = "NimblePros, Hudson, OH 44236";
            Console.WriteLine(upsOrder.Ship());

            Console.WriteLine("Sending order FedEx:");
            OrderShipment fedExOrder = new FedExOrderShipment();
            fedExOrder.ShippingAddress = "NimblePros, Hudson, OH 44236";
            Console.WriteLine(fedExOrder.Ship());

            Console.ReadLine();
        }
    }
}
