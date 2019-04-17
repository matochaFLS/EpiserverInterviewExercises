using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiserverInterviewExercises.Models.Commerce
{
    public class Product
    {
        public decimal Price { get; set; }

        public decimal? MaxDiscount { get; set; }

        public bool OnlineDiscount { get; set; }
    }
}