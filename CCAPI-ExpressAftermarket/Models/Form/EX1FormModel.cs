using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCAPI_ExpressAftermarket.Models.Form
{
    public class EX1FormModel
    {
        public EX1FormRequest EX1FormRequest {get;set;}
    }
    public class EX1FormRequest { 
        public int EX1DealerID { get; set; }
        public FormContract Contract { get; set; }
    }
    public class FormContract {
        public int EX1ProviderID { get; set; }
        public String ContractNumber { get; set; }
        public String ContractType { get; set; }
    }
}
