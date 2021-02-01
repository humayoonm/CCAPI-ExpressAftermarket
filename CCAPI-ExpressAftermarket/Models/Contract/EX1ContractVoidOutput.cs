using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCAPI_ExpressAftermarket.Models.Contract
{
    public class EX1ContractVoidOutput
    {
        public EX1ContractVoidResponse EX1ContractVoidResponse { get; set; }
    }
    public class EX1ContractVoidResponse
    {
        public ResponseModel MsgHeader { get; set; }
        public ContractVoid Contract { get; set; }
    }
    public class ContractVoid
    {
        public int EX1ProviderID { get; set; }
        public string ProviderName { get; set; }
        public string ContractNumber { get; set; }
        public string ContractStatus { get; set; }
         
    }
}
