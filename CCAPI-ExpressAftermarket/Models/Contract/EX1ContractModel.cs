
using CCAPI_ExpressAftermarket.Models.Rating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CCAPI_ExpressAftermarket.Models.Contract
{
    public class EX1ContractModel
    {
        public EX1ContractRequest EX1ContractRequest { get; set; }
    }
    public class EX1ContractRequest
    {
        public Deal Deal { get; set; }
        public string EX1DealerID { get; set; }
        public List<string> FormFields { get; set; }

    }
    public class Deal
    {
               public ContaractVehicle Vehicle { get; set; }        
        public string DealType { get; set; }        
        public string MSRP { get; set; }           
        public string SaleDate { get; set; }
        public string VehicleSalePrice { get; set; }       
        public FinanceTerms FinanceTerms { get; set; }   
        public Products Products { get; set; }  
        public Buyer Buyer { get; set; }
        public Buyer CoBuyer { get; set; }              
        public string DealNumber { get; set; }

        public string FinanceMgrFname { get; set; }
        public string FinanceMgrLname { get; set; }         


 

    }
    public class FinanceTerms
    {
        public Lienholder Lienholder { get; set; }
        public string FinanceAmount { get; set; }
        public string FinanceRate { get; set; }
        public string MonthlyPayment { get; set; }
        public string FinanceTerm { get; set; }
        public string ResidualAmount { get; set; }
        public string AmortTerm { get; set; }
        public string DownPayment { get; set; }
        public string FirstPaymentDate { get; set; }
    }
    public class Lienholder
    {
        public string Name { get; set; }
        public Contact Contact { get; set; }
    }
    public class Contact
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string TimeZone { get; set; }
        public string Facsimile { get; set; }
        public string eMail { get; set; }
    }
    public class ContaractVehicle
    {
        public string VIN { get; set; }
        public string InServiceDate { get; set; }
        public string Odometer { get; set; }
        public string CarStatus { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Trim { get; set; }
        public string StockNumber { get; set; }
    }

    public class Products
    {
        public Product Product { get; set; }
    }
    public class Product
    {
        public string EX1RateResponseID { get; set; }
        public string  RetailPrice { get; set; }
        public string  DealerCost { get; set; }
        public string  SellingPrice { get; set; }
        public Attributes Attributes { get; set; }
        public string ContractFormID { get; set; }
        public string ProductCode { get; set; }
        public ContractSurcharges Surcharges { get; set; }
    }
    public class ContractSurcharges
    {
        public List<ContractSurcharge>  Surcharge { get; set; }
    }
    public class ContractSurcharge 
    {
        public string SurchargeCode { get; set; }
        public string Value { get; set; }
    }
    public class Attributes
    {
        public string Coverage { get; set; }
        public string Months { get; set; }
        public string Term { get; set; }
        public string Miles { get; set; }
        public string Deductible { get; set; }
        public string ServiceInterval { get; set; }
        public string TireRotations { get; set; }
    }
    public class Buyer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Contact Contact { get; set; }
    }
}
