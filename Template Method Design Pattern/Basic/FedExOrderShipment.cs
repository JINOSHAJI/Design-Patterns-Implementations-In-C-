using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Design_Pattern.Basic
{
    public class FedExOrderShipment : OrderShipment
    {
        public override void GetShippingLabelFromCarrier()
        {
            // Call FedEx Web Service
            Label = String.Format("FedEx:[{0}]", ShippingAddress);
        }
    }
}
