using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCAPI_ExpressAftermarket.Models.Rating
{
    public class EX1RateModel
    {
        public EX1RateRequest EX1RateRequest { get; set; }
    }
    public class EX1RateRequest
    {
        public int EX1DealerID { get; set; }
        public int EX1ProductID { get; set; }
        public Vehicle Vehicle { get; set; }
    }
 


}
