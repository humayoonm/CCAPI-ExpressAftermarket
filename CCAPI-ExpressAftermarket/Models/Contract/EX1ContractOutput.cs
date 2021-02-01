using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCAPI_ExpressAftermarket.Models.Contract
{
    public class EX1ContractOutput
    {
        public EX1ContractResponse EX1ContractResponse { get; set; }
    }
    public class EX1ContractResponse
    {
        public ResponseModel MsgHeader { get; set; }
        public ContractProducts Products { get; set; }
    }
    public class ContractProducts
    { 
        public  List<ContractProductList> Product { get;set;}
    }
    public class ContractProductList
    {
        public string EX1ProductID { get; set; }
        public decimal SellingPrice { get; set; }
        public string ContractFormID { get; set; }
        public string ContractNumber { get; set; }
        public ContractProductDetail Product { get; set; }
    }
    public class ContractProductDetail
    {
        public string EX1ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
    }
}
