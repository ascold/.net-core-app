using CoreApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        static List<Restaurant> _restaurants = null;

        static InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name="Chez Cora" },
                new Restaurant { Id = 2, Name="Georgios' fries" },
                new Restaurant { Id = 3, Name="Mamma mia" }
            };
        }

        public Restaurant Add(Restaurant newRestaurant)
        {
            newRestaurant.Id = _restaurants.Max(r=>r.Id) + 1;
            _restaurants.Add(newRestaurant);

            return newRestaurant;
        }

        [HttpGet]
        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(restaurant => restaurant.Id == id);
        }

        [HttpPost]
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }
    }
}
