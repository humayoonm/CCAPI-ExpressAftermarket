using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCAPI_ExpressAftermarket.Models
{

    public class FormField
    {
        public string FormName { get; set; }
        public string  FieldName { get; set; }
        public string DataType { get; set; }
        public string  Prompt { get; set; }
        public List<string>   FieldOptions { get; set; }
        public string    Required { get; set; }
    }
}
