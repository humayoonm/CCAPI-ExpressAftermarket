using CCAPI_ExpressAftermarket.Models;
using CCAPI_ExpressAftermarket.Models.Contract;
using CCAPI_ExpressAftermarket.Models.Form;
using CCAPI_ExpressAftermarket.Models.Rating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCAPI_ExpressAftermarket.Repository
{
    public class TestData
    {
        public EX1PreRateModel GetGapPreRateData()
        {
            EX1PreRateModel data = new EX1PreRateModel
            {
                EX1PreRateRequest = new EX1PreRateRequest
                {
                    EX1DealerID = 2639,
                    EX1ProductID = 80,
                    Vehicle = new Vehicle()
                    {
                        VIN = "1G1ZD5ST7LF022958",
                        Odometer = 2,
                        CarStatus = "New",
                        DealType = "Loan",
                        Optional = null,
                        Supplemental = null
                    }
                }
            };
            return data;
        }
        public EX1RateModel GetGapRateData()
        {
            //Supplemental Surcharges needed must for all
            //    CONTRACTDATE, INSDATE,AFINANCED
            EX1RateModel data = new EX1RateModel
            {
                EX1RateRequest = new EX1RateRequest
                {
                    EX1DealerID = 2639,
                    EX1ProductID = 80,
                    Vehicle = new Vehicle
                    {
                        VIN = "JTJBM7FX3A5009853",
                        Odometer = 2,
                        CarStatus = "Used",
                        DealType = "Loan",
                        Optional = null,
                        Supplemental = new RequestSurcharge
                        {
                            Surcharge = new List<SurchargeDetail> {
                                new SurchargeDetail{ SurchargeCode="CONTRACTDATE", Value="2021-01-18"},
                                new SurchargeDetail{ SurchargeCode="INSDATE", Value="2021-01-18"}
                            }

                        }
                    }
                }
            };



            return data;
        }

        public EX1PreRateModel GetVSCPreRateData()
        {
            EX1PreRateModel data = new EX1PreRateModel
            {
                EX1PreRateRequest = new EX1PreRateRequest
                {
                    EX1DealerID = 2639,
                    EX1ProductID = 86,
                    Vehicle = new Vehicle()
                    {
                        VIN = "JTJBM7FX3A5009853",
                        //1G1ZD5ST7LF022958
                        Odometer = 5000,
                        CarStatus = "Used",
                        DealType = "Loan",
                        Optional = null,
                        Supplemental = null
                    }
                }
            };
            return data;
        }
        public EX1RateModel GetVSCRateData()
        {
            //Supplemental Surcharges needed must for all
            //    CONTRACTDATE, ,
            EX1RateModel data = new EX1RateModel
            {
                EX1RateRequest = new EX1RateRequest
                {
                    EX1DealerID = 2639,
                    EX1ProductID = 368,
                    Vehicle = new Vehicle
                    {//JTJBM7FX3A5009853,JTJBM7FX3A5009853
                        VIN = "JTJBM7FX3A5009853",
                        Odometer = 5000,
                        CarStatus = "Used",
                        DealType = "Loan",
                        Optional = null
                        ,
                        Supplemental = new RequestSurcharge
                        {
                            Surcharge = new List<SurchargeDetail> { 
                                new SurchargeDetail{ SurchargeCode="CONTRACTDATE", Value="2021-01-17"}//,
                                //new SurchargeDetail{ SurchargeCode="INSDATE", Value="2021-01-17"} //,
                                //new SurchargeDetail{ SurchargeCode="VEHPURDATE", Value="2021-01-17"},
                                //new SurchargeDetail{ SurchargeCode="VEHPURPRICE", Value="24000"}
                            }

                        }
                    }
                }
            };     
            return data;
        }
        public EX1ContractModel GetVSCContractData()
        {
            EX1ContractModel data = new EX1ContractModel
            {
                EX1ContractRequest = new EX1ContractRequest
                {
                    EX1DealerID = "2639",
                    FormFields = null ,
                    Deal = new Deal
                    {
                        Vehicle = new ContaractVehicle
                        {
                            VIN = "1G1ZD5ST7LF022958",
                            InServiceDate = "2021-01-01",
                            Odometer = "5000",
                            CarStatus = "Used",
                            Make = "Chevrolet",
                            Model = "Malibu",
                            Year = "2020",
                            Trim = null,
                            StockNumber = null
                        },
                        DealType = "Loan",
                        MSRP = "24000",
                        SaleDate = "2021-01-19",
                        VehicleSalePrice = "23500",
                        FinanceTerms = new FinanceTerms
                        {
                            FinanceAmount = "24000",
                            FinanceRate = "6.0",
                            MonthlyPayment = "437.00",
                            FinanceTerm = "60",
                            ResidualAmount = "26232.00",
                            AmortTerm = "20",
                            DownPayment = "100.00",
                            FirstPaymentDate = "2021-01-19",
                            Lienholder = new Lienholder
                            {
                                Name = "BANK OF AMERICA",
                                Contact = new Contact
                                {
                                    AddressLine1 = "123 MAIN STREET",
                                    AddressLine2 = "456 STREET2",
                                    City = "SAN PEDRO",
                                    State = "CA",
                                    PostalCode = "90731",
                                    Country = null,
                                    Phone = "123-331-1234",
                                    TimeZone = null,
                                    Facsimile = null,
                                    eMail = "lien@email.com"
                                }
                            }

                        },
                        Products = new Products
                        {
                            Product = new Product
                            {
                                EX1RateResponseID = "92554e0999173a56d565ea125c03f35c",
                                RetailPrice = "422.00",
                                DealerCost = "422.00",
                                SellingPrice = "422.00",
                                Attributes = new Attributes
                                {
                                    Coverage = "Absolute Reserve Car Plus - Exclusionary",
                                    Months = "36",
                                    Term = "0",
                                    Miles = "6000",
                                    Deductible = "100",
                                    ServiceInterval = "0",
                                    TireRotations = "0",
                                },
                                ContractFormID = "-",
                                ProductCode = "VSC",
                                Surcharges = new ContractSurcharges
                                {

                                    Surcharge = new List<ContractSurcharge>
                                        {

                                            new ContractSurcharge{ SurchargeCode="CONTRACTDATE", Value="2021-01-17"},
                                            new ContractSurcharge{ SurchargeCode="COMM", Value="false"},
                                            new ContractSurcharge{ SurchargeCode="TURBO", Value="false"}
                                        }

                                }

                            },
                        },
                        Buyer = new Buyer
                        {
                            FirstName = "John",
                            LastName = "Doe",
                            Contact = new Contact
                            {
                                AddressLine1 = "Street 1",
                                AddressLine2 = "Street 2",
                                City = "Los Angeles",
                                State = "CA",
                                PostalCode = "CA",
                                Country = "US",
                                Phone = "225-201-3112",
                                TimeZone = null,
                                Facsimile = null,
                                eMail = "test@email.com"
                            }
                        },
                        CoBuyer = new Buyer
                        {
                            FirstName = "Jane",
                            LastName = "Doe",
                            Contact = new Contact
                            {
                                AddressLine1 = "Street co 1",
                                AddressLine2 = "Street co 2",
                                City = "Houston",
                                State = "TX",
                                PostalCode = "90731",
                                Country = "US",
                                Phone = "333-111-3112",
                                TimeZone = null,
                                Facsimile = null,
                                eMail = "testco@email.com"
                            }
                        },
                        FinanceMgrFname = "TH FinanceMgrFN",
                        FinanceMgrLname = "TH FinanceMgrLN",
                        DealNumber = "1610383886903"
                    }
                }
            };
            return data;
        }



        public EX1ContractModel GetGapContractData()
        {
            EX1ContractModel data = new EX1ContractModel
            {
                EX1ContractRequest = new EX1ContractRequest
                {
                    EX1DealerID = "2639",
                    FormFields = null,
                    Deal = new Deal
                    {
                        Vehicle = new ContaractVehicle
                        {
                            VIN = "1G1ZD5ST7LF022958",
                            InServiceDate = "2021-01-11",
                            Odometer = "2",
                            CarStatus = "New",
                            Make = "Chevrolet",
                            Model = "Malibu",
                            Year = "2020",
                            Trim = null,
                            StockNumber = null
                        },
                        DealType = "Loan",
                        MSRP = "24000",
                        SaleDate = "2021-01-11",
                        VehicleSalePrice = "23500",
                        FinanceTerms = new FinanceTerms
                        {
                            FinanceAmount = "24000",
                            FinanceRate = "6.0",
                            MonthlyPayment = "437.00",
                            FinanceTerm = "60",
                            ResidualAmount = "26232.00",
                            AmortTerm = "20",
                            DownPayment = "100.00",
                            FirstPaymentDate = "2021-01-11",
                            Lienholder = new Lienholder
                            {
                                Name = "BANK OF AMERICA",
                                Contact = new Contact
                                {
                                    AddressLine1 = "123 MAIN STREET",
                                    AddressLine2 = "456 STREET2",
                                    City = "SAN PEDRO",
                                    State = "CA",
                                    PostalCode = "90731",
                                    Country = null,
                                    Phone = "123-331-1234",
                                    TimeZone = null,
                                    Facsimile = null,
                                    eMail = "lien@email.com"
                                }
                            }

                        },
                        Products = new Products
                        {
                            Product = new Product
                            {
                                EX1RateResponseID = "7621f0d2e8edd52eb82a93f5ee8c2936",
                                RetailPrice = "119.00",
                                DealerCost = "119.00",
                                SellingPrice = "119.00",
                                Attributes = new Attributes
                                {
                                    Coverage = "New - GAPWise 150 - GAPWise Core 150GW FG120",
                                    Months = "60",
                                    Term = "0",
                                    Miles = "0",
                                     Deductible = "0",
                                    ServiceInterval = "0",
                                    TireRotations = "0",
                                },
                                ContractFormID = "150GW_FG120_0220",
                                ProductCode = "GAP",
                                Surcharges = new ContractSurcharges
                                {
                                   
                                        Surcharge = new List<ContractSurcharge>
                                        {
                                            new ContractSurcharge{ SurchargeCode="COMM", Value="false"},
                                            new ContractSurcharge{ SurchargeCode="LATEFEE", Value="false"}
                                        }
                                                                    
                                }

                            },
                        },
                        Buyer = new Buyer
                        {
                            FirstName = "John",
                            LastName = "Doe",
                            Contact = new Contact
                            {
                                AddressLine1 = "Street 1",
                                AddressLine2 = "Street 2",
                                City = "Los Angeles",
                                State = "CA",
                                PostalCode = "CA",
                                Country = "US",
                                Phone = "225-201-3112",
                                TimeZone = null,
                                Facsimile = null,
                                eMail = "test@email.com"
                            }
                        },
                        CoBuyer = new Buyer
                        {
                            FirstName = "Jane",
                            LastName = "Doe",
                            Contact = new Contact
                            {
                                AddressLine1 = "Street co 1",
                                AddressLine2 = "Street co 2",
                                City = "Houston",
                                State = "TX",
                                PostalCode = "90731",
                                Country = "US",
                                Phone = "333-111-3112",
                                TimeZone = null,
                                Facsimile = null,
                                eMail = "testco@email.com"
                            }
                        },
                        FinanceMgrFname = "TH FinanceMgrFN",
                        FinanceMgrLname = "TH FinanceMgrLN",
                        DealNumber = "1610383886903"
                    }
                }
            };        
            return data;
        }
        public EX1FormModel GetFormData()
        {
            EX1FormModel data = new EX1FormModel
            {
                 EX1FormRequest=new EX1FormRequest
                 {
                     EX1DealerID=2639,
                     Contract=new FormContract
                     {
                        EX1ProviderID =12,
                        ContractNumber = "A-11070766-152478-150GWQF00477911",
                        ContractType ="Link"
                     }
                 }
            };
            return data;
        }

        public EX1ContractVoidModel GetContractVoidData()
        {
            EX1ContractVoidModel data = new EX1ContractVoidModel
            {
                EX1ContractVoidRequest = new EX1ContractVoidRequest
                {
                    EX1DealerID = 2639,
                    Contract = new Contract
                    {
                        EX1ProviderID = 12,
                        ContractNumber = "A-11070766-152477-150GWQF00477910"
                    }
                }
            };
            return data;
        }


    }
}
