using MenuService.Contract.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MenuService.Contract
{
    public class DishDetail
    {
        /// <summary>
        /// This is the unique Id of the Dish
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// This is the name of the Dish
        /// </summary>
        [Required]
        public string DishName { get; set; }
        /// <summary>
        /// This is the Chinese name of the Dish
        /// </summary>
        public string ChineseDishName { get; set; }
        /// <summary>
        /// This is the list of the Image.
        /// It will return the URLs of the Image
        /// </summary>
        public List<string> ImgList { get; set; }
        /// <summary>
        /// This is the primary image Url
        /// </summary>
        public string PrimaryImg { get; set; }
        /// <summary>
        /// Choose List some it will allow people 
        /// to choose spicy or not rare or well done
        /// </summary>
        public string ChooseList { get; set; }
        /// <summary>
        /// Veg or not
        /// </summary>
        [ValidEnumValue]
        public string Veg { get; set; }
        /// <summary>
        /// Catagory of this dish
        /// </summary>
        public string Catagory { get; set; }
        /// <summary>
        /// Dish Introducation
        /// </summary>
        public string Introducation { get; set; }
        /// <summary>
        /// Other Customer Requirements
        /// </summary>
        public string CustomerRequirements { get; set; }
        /// <summary>
        /// Other Merchant Requirements
        /// </summary>
        public string MerchantComments { get; set; }
        /// <summary>
        /// Dish Price
        /// </summary>
        public Price DishPrice { get; set; }

    }
}