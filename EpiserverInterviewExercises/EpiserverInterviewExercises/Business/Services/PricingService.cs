using EpiserverInterviewExercises.Business.Interfaces;
using EpiserverInterviewExercises.Models.Commerce;
using System;

namespace EpiserverInterviewExercises.Business.Services
{
    public class PricingService : IPricingService
    {
        private const decimal OnlineDiscountValue = 1.5m;  

        public decimal? GetCustomerProductPrice(bool isUserLoggedIn, decimal orgDiscount, Product product)
        {

            if (!isUserLoggedIn)
            {
                return null;
            }

            // Organisation discount
            decimal discount = product.MaxDiscount.HasValue && orgDiscount > product.MaxDiscount.Value ? product.MaxDiscount.Value : orgDiscount;
            decimal customerPrice = ApplyDiscount(discount, product.Price);

            // Online discount
            if (product.OnlineDiscount)
            {
                customerPrice = ApplyDiscount(OnlineDiscountValue, customerPrice);
            }

            return Math.Round(customerPrice, 2);
        }

        private decimal ApplyDiscount(decimal discount, decimal price)
        {
            return price * (1 - discount/100);
        }
    }
}