
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCAPI_ExpressAftermarket.Models.Contract
{
    public class EX1ContractVoidModel
    {
        public EX1ContractVoidRequest EX1ContractVoidRequest { get; set; }
    }
    public class EX1ContractVoidRequest
    {
        public int EX1DealerID { get; set; }
        public Contract Contract { get; set; }
    }
    public class Contract
    {
        public int EX1ProviderID { get; set; }
        public string ContractNumber { get; set; }
    }
}
