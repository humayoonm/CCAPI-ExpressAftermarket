using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCAPI_ExpressAftermarket.Models.Rating
{
    public class EX1RateOutput
    {
        public EX1RateResponse EX1RateResponse { get; set; }

    }

    public class EX1RateResponse
    {
        public ResponseModel MsgHeader { get; set; }
        public RateResponse RateResponse { get; set; }

    }
    public class RateResponse
    {
        public string ProductCode { get; set; }
        public int EX1ProviderID { get; set; }
        public int EX1ProductID { get; set; }
        public Boolean MultipleAllowed { get; set; }
        public RatesVSC RatesVSC { get; set; }
        public RatesGAP RatesGAP { get; set; }
        public FormFields FormFields { get; set; }
        public RateVehicle Vehicle { get; set; }
    }
    public class RatesGAP
    {
        public List<GAPCoverage> Coverage { get; set; }
    }
    public class GAPCoverage
    {
        public string Value { get; set; }
        public List<GAPMonths> Months { get; set; }
    }
    public class GAPMonths
    {
        public int Value { get; set; }
        public string RetailPrice { get; set; }
        public string DealerCost { get; set; }
        public string RemitPrice { get; set; }
        public string ContractFormID { get; set; }
        public string EX1RateResponseID { get; set; }
        public string MaxPrice { get; set; }
        public List<DynamicSurcharge> DynamicSurcharge { get; set; }
    }
    public class RatesVSC
    {
        public List<VSCCoverage> Coverage { get; set; }
    }
    public class VSCCoverage
    {
        public string Value { get; set; }
        public List<VSCMonths> Months { get; set; }
    }
    public class VSCMonths
    {
        public string Value { get; set; }
        public List<Miles> Miles { get; set; }
    }
    public class Miles
    {
        public string Value { get; set; }
        public List<Deductible> Deductible { get; set; }
    }
    public class Deductible
    {
        public string Value { get; set; }
        public string RetailPrice { get; set; }
        public string DealerCost { get; set; }
        public string RemitPrice { get; set; }
        public string ContractFormID { get; set; }
        public string EX1RateResponseID { get; set; }
        public string MinPrice { get; set; }
        public string MaxPrice { get; set; }
        public List<DynamicSurcharge> DynamicSurcharge { get; set; }
    }
    public class DynamicSurcharge
    {
        public string SurchargeCode { get; set; }
        public string Value { get; set; }
        public string Price { get; set; }
        public string Cost { get; set; }
        public string Description { get; set; }
        public bool IsEditable { get; set; }
    }


    public class RateVehicle{
        public string VIN { get; set; }
        public int Odometer { get; set; }
        public string CarStatus { get; set; }
        public RateSurchargeList Surcharges { get; set; }
        //public List<MandatorySurcharges> MandatorySurcharges { get; set; }
        //public List<OptionalSurcharges> OptionalSurcharges { get; set; }
        //public List<SupplementalCodes> SupplementalCodes { get; set; }
        public string Trim { get; set; }
    }

    public class RateSurchargeList
    {
        public List<RateSurcharge> Surcharge { get; set; }
    }
    public class RateSurcharge
    {
        public string SurchargeCode { get; set; }
        public string DataType { get; set; }
        public string Prompt { get; set; }
        public string SurchargeType { get; set; }
        public string Value { get; set; }
    }
    public class MandatorySurcharges
    {
        public string SurchargeCode { get; set; }
        public string Value { get; set; }
        public string IsDefault { get; set; }
        public string DataType { get; set; }
        public string Description { get; set; }
    }
    public class OptionalSurcharges
    {
        public string SurchargeCode { get; set; }
        public string Value { get; set; }
        public string IsDefault { get; set; }
        public string DataType { get; set; }
        public string Description { get; set; }
    }
    public class SupplementalCodes
    {
        public string SupplementalCode { get; set; }
        public string Value { get; set; }
        public string DataType { get; set; }
        public string Description { get; set; }
    }


    public class FormFields
    {
        public List<FormField> FormField { get; set; }
    }
}
