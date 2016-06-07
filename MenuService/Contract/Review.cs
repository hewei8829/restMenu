using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuService.Contract
{
    public class Review
    {
        /// <summary>
        /// Review Unique Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Review time
        /// </summary>
        public DateTime ReviewTime { get; set; }
        /// <summary>
        /// Review of the dish
        /// </summary>
        public string Comments { get; set; }
        /// <summary>
        /// All the img updated from costomer
        /// </summary>
        public List<string> ImgList;
    }
}
