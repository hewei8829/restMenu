using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuService.Contract
{
    public class DishReviews
    {
        /// <summary>
        /// Average rating for certain dish
        /// </summary>
        public double AverageRating { get; set; }
        /// <summary>
        /// All the reviews of the dishes
        /// </summary>
        public List<Review> ReviewList;
    }
}
