using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData() {

            restaurants = new List<Restaurant>()
            {
                new Restaurant { id = 1, Name = "Scott's Pizza", Cuisine = CuisineType.Italian},
                new Restaurant { id = 2, Name = "Tersiguels", Cuisine = CuisineType.Indian},
                new Restaurant { id = 3, Name = "Mango Grove", Cuisine = CuisineType.French}
            };
        
        }

        public void Add(Restaurant restaurant) 
        {
            restaurants.Add(restaurant);
            restaurant.id = restaurants.Max(x => x.id) + 1;
        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
