using Microsoft.Extensions.Configuration;

namespace CoreApp
{
    public class BasicGreeter : IGreeter
    {
        private string _greeting;

        public BasicGreeter(IConfiguration configuration)
        {
            _greeting = configuration["Greeting"];
        }

        public string GetGreeting()
        {
            return _greeting;
        }
    }
}
