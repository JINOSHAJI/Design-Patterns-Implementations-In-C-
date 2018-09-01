using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Design_Pattern.Basic
{
    public class UpsOrderShipment : OrderShipment
    {
        public override void GetShippingLabelFromCarrier()
        {
            // Call UPS Web Service
            Label = String.Format("UPS:[{0}]", ShippingAddress);
        }
    }
}
