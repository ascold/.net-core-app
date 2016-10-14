using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_app
{
    public class BasicGreeter : IGreeter
    {
        public string GetGreeting()
        {
            return "Basic Hello";
        }
    }
}
