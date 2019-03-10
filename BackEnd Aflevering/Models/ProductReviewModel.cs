using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd_Aflevering.Models
{
    public class ProductReviewModel
    {
        private Guid guid { get; set; }
        public String Name { get; set; }
        public string Product { get; set; }
        public int Score { get; set; } = 0; 


    }
} 