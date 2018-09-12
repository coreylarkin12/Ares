using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {

        public InMemoryRestaurantData()
        {
            _restaurant = new List<Restaurant>
            {
                new Restaurant {Id = 1, Name = "Arbys"},
                new Restaurant {Id = 2, Name = "O'Larkin's"},
                new Restaurant {Id = 3, Name ="Wendy's"},

            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurant.OrderBy(r => r.Name);
        }

        public Restaurant Get(int id)
        {
            return _restaurant.FirstOrDefault(r => r.Id == id);
        }

        public Restaurant Add(Restaurant restaurant)
        {
            restaurant.Id = _restaurant.Max(r => r.Id) + 1;
            _restaurant.Add(restaurant);
            return restaurant;
        }

        List<Restaurant> _restaurant;


    }
}
