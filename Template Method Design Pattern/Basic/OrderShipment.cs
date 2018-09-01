using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Design_Pattern.Basic
{
//    An shipment system may have the following steps.
//    Step 1:  Verify shipping data
//    Step 2:  Get shipping label from Carrier
//    Step 3:   Print Label
// Template method defines the different steps in the algorithm
    public abstract class OrderShipment
    {
        public string ShippingAddress { get; set; }
        public string Label { get; set; }
        public string Ship()
        {
            VerifyShippingData();
            GetShippingLabelFromCarrier();
            return PrintLabel();
        }

        public virtual void VerifyShippingData()
        {
            if (String.IsNullOrEmpty(ShippingAddress))
            {
                throw new ApplicationException("Invalid address.");
            }
        }
        public abstract void GetShippingLabelFromCarrier();
        public virtual string PrintLabel()
        {
            return Label;
        }
    }

}
