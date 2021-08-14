using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMSDALayer
{
    public class CreditCardDTO
    {
        //Used to Create Data Transfer Objects that will host that data transmitted
        //to and from the Business Object layer & Data Access Layer
        //on behalf of the CreditCard Class object

        //Properties using the Short-hand syntax
        public string CreditCardNumber { get; set; }
        public string CreditCardOwnerName { get; set; }
        public string MerchantName { get; set; }
        public DateTime ExpDate { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public decimal CreditCardLimit { get; set; }
        public decimal CreditCardBalance { get; set; }
        public bool ActivationStatus { get; set; }
    }
}
