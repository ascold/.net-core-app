using CoreApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreApp.Services
{
    public class SqlServerRestaurantData : IRestaurantData
    {
        private CoreAppDbContext _context;

        public SqlServerRestaurantData(CoreAppDbContext  context)
        {
            _context = context;
        }

        // in "real-life" scenarionsuse SaveChanges() after all the transactions 
        // in the same "context" have been executed
        public Restaurant Add(Restaurant newRestaurant)
        {
            _context.Add(newRestaurant);
            return newRestaurant;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public Restaurant Get(int id)
        {
            return _context.Restaurants.FirstOrDefault(restaurant => restaurant.Id == id);
        }

        //use IQueryable in real case scenarios
        public IEnumerable<Restaurant> GetAll()
        {
            return _context.Restaurants;
        }
    }
}
