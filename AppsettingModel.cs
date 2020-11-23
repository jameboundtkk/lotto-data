using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class AppsettingModel
    {
        public ConnectionStringModel ConnectionStrings { get; set; }
    }
    public class ConnectionStringModel
    {
        public string LOTTODB { get; set; }
    }
}
