using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HB.Ecommerce.Web.Models
{
    public class InputOutputViewModel
    {
        public List<string> Commands { get; set; }
        public List<OutputData> Outputs { get; set; }
    }

    public class OutputData
    {
        public string Command { get; set; }
        public string Output { get; set; }
    }
}
