using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MenuService.Contract;

namespace MenuService.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public Dish Get()
        {
            var dish = new Dish
            {
                dishDetail = new DishDetail()
                {
                    Id = Guid.NewGuid(),
                    DishName = "DishName"
                },
                dishReview = new DishReviews()
                {
                    AverageRating = 3.0,
                    ReviewList = new List<Review>
                    {
                        new Review
                        {
                            Id = Guid.NewGuid(),
                            Comments = "Something",
                        }
                    }
                }
            };
            return dish;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
