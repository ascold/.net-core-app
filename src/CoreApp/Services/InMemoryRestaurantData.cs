using CoreApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Entities;

namespace CoreApp.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> _restaurants = null;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name="Chez Cora" },
                new Restaurant { Id = 2, Name="Georgios' fries" },
                new Restaurant { Id = 3, Name="Mamma mia" }
            };
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(restaurant => restaurant.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }
    }
}
