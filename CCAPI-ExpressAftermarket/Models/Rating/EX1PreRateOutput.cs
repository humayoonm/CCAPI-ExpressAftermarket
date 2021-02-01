using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCAPI_ExpressAftermarket.Models.Rating
{
    public class EX1PreRateOutput
    {
        public PreRateResponse EX1PreRateResponse { get; set; }

    }

    public class PreRateResponse {
        public ResponseModel MsgHeader { get; set; }
        public SurchargeList Surcharges { get; set; }

    }
    public class  SurchargeList {
        public List<Surcharge> Surcharge { get; set; }
    }
    public class Surcharge
    {
        public string SurchargeCode { get; set; }
        public string DataType { get; set; }
        public string Prompt { get; set; }
        public string SurchargeType { get; set; }
    }
}
