using EpiserverInterviewExercises.Models.Commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiserverInterviewExercises.Business.Interfaces
{
    public interface IPricingService
    {
        decimal? GetCustomerProductPrice(bool isUserLoggedIn, decimal orgDiscount, Product product);
    }
}
