using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCAPI_ExpressAftermarket.Models
{
    // This class needs to be part of the every Response/Output
    public class ResponseModel
    {
        public List<Message> Message { get; set; }
    }
    public class Message
    {
        public int StatusCode { get; set; }
        public string Description { get; set; } //0 is the success any other there is issue
        public string Timestamp { get; set; }

    }
}