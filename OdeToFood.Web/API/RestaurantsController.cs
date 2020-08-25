using OdeToFood.Data.Models;
using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OdeToFood.Web.API
{
    public class RestaurantsController : ApiController
    {
        private readonly IRestaurantData db;

        public RestaurantsController(IRestaurantData db) 
        {
            this.db = db;
        }


        public IEnumerable<Restaurant> Get()
        {
            //return "Hello API WORLD!"; test code.

            var model = db.GetAll();
            return model;

        }
    }
}
