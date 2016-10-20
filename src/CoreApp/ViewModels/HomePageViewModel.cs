using CoreApp.Entities;
using System.Collections.Generic;

namespace CoreApp.ViewModels
{
    public class HomePageViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
    }
}
