
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCAPI_ExpressAftermarket.Models
{
    public class Vehicle
    {
        public string VIN { get; set; }
        public int Odometer { get; set; }
        public string CarStatus { get; set; }
        public string DealType { get; set; }
        public RequestSurcharge Optional { get; set; }
        public RequestSurcharge Supplemental { get; set; }
    }
    public class RequestSurcharge
    {
        public List<SurchargeDetail> Surcharge { get; set; }
    }
    public class SurchargeDetail
    {
        public string SurchargeCode { get; set; }
        public string Value { get; set; }
    }
}
