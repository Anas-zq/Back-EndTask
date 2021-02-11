using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskForSteadyPoint.Models
{
    public class CustomException :Exception
    {
        public string CustomMessage { get; set; }
    }
}
