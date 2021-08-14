using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMSDALayer
{
    public class CountryDTO
    {
        public int CountryID { get; set; }
        /*
        public string CountryCode2 { get; set; }
        public string CountryCode3 { get; set; }
        */
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string NumericCode { get; set; }
    }
}
