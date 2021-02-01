using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCAPI_ExpressAftermarket.Models.Contract
{
    public class EX1FormOutput
    {
        public EX1FormResponse EX1FormResponse { get; set; }
    }
    public class EX1FormResponse
    {
        public ResponseModel MsgHeader { get; set; }
        public List<Contracts> Contracts { get; set; }
    }
    public class Contracts
    {
        public int EX1ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public FormProduct Product { get; set; }
    }

    public class FormProduct
    {
        public decimal SellingPrice { get; set; }
        public int ContractFormID { get; set; }
        public string ContractNumber { get; set; }
        public string ContractForm { get; set; }
        public SigCoords SigCoords { get; set; }
    }
    public class SigCoords
    {
        public string CoordsMappingType { get; set; }
        public Pages Pages { get; set; }
    }

    public class Pages
    {
        public List<Page> Page { get; set; }
    }
    
    public class Page
    {
        public int PageNo  { get; set; }
        public int PageHeight   { get; set; }
        public int PageWidth   { get; set; }
        public  Coords  Coords { get; set; }
    }
    public class Coords
    {
        public List<Coord> Coord { get; set; }
    }
    public class Coord
    {
        public int CoordNo { get; set; }
        public string SigType { get; set; }
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}
