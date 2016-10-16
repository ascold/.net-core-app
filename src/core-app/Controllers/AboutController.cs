using Microsoft.AspNetCore.Mvc;

namespace core_app.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "154-455-6654";
        }

        public string Address()
        {
            return "USA";
        }
    }

    
}
