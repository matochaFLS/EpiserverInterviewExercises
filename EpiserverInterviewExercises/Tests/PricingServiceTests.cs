using System;
using EpiserverInterviewExercises.Business.Interfaces;
using EpiserverInterviewExercises.Business.Services;
using EpiserverInterviewExercises.Models.Commerce;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class PricingServiceTests
    {
        [TestMethod]
        public void GetCustomerProductPrice_Scenario1()
        {
            // Arrange
            decimal? expectedResult = 32.98m;

            bool isUserLoggedIn = true;
            decimal orgDiscount = 7.0m;
            var product = new Product
            {
                Price = 36.00m,
                OnlineDiscount = true,
                MaxDiscount = null
            };
           
            IPricingService pricingService = new PricingService();

            // Act
            var resutl = pricingService.GetCustomerProductPrice(isUserLoggedIn, orgDiscount, product);

            // Assert
            Assert.AreEqual(expectedResult, resutl);
        }

        [TestMethod]
        public void GetCustomerProductPrice_Scenario2()
        {
            // Arrange
            decimal? expectedResult = 113.51m;

            bool isUserLoggedIn = true;
            decimal orgDiscount = 12.0m;
            var product = new Product
            {
                Price = 128.99m,
                OnlineDiscount = false,
                MaxDiscount = null
            };

            IPricingService pricingService = new PricingService();

            // Act
            var resutl = pricingService.GetCustomerProductPrice(isUserLoggedIn, orgDiscount, product);

            // Assert
            Assert.AreEqual(expectedResult, resutl);
        }


        [TestMethod]
        public void GetCustomerProductPrice_Scenario3()
        {
            // Arrange
            decimal? expectedResult = null;

            bool isUserLoggedIn = false;
            decimal orgDiscount = 0;
            var product = new Product
            {
                Price = 128.99m,
                OnlineDiscount = true,
                MaxDiscount = null
            };

            IPricingService pricingService = new PricingService();

            // Act
            var resutl = pricingService.GetCustomerProductPrice(isUserLoggedIn, orgDiscount, product);

            // Assert
            Assert.AreEqual(expectedResult, resutl);
        }

        [TestMethod]
        public void GetCustomerProductPrice_Scenario4()
        {
            // Arrange
            decimal? expectedResult = 32.4m;

            bool isUserLoggedIn = true;
            decimal orgDiscount = 15;
            var product = new Product
            {
                Price = 36.00m,
                OnlineDiscount = false,
                MaxDiscount = 10
            };

            IPricingService pricingService = new PricingService();

            // Act
            var resutl = pricingService.GetCustomerProductPrice(isUserLoggedIn, orgDiscount, product);

            // Assert
            Assert.AreEqual(expectedResult, resutl);
        }

        [TestMethod]
        public void GetCustomerProductPrice_Scenario5()
        {
            // Arrange
            decimal? expectedResult = 30.96m;

            bool isUserLoggedIn = true;
            decimal orgDiscount = 15;
            var product = new Product
            {
                Price = 36.00m,
                OnlineDiscount = false,
                MaxDiscount = 14
            };

            IPricingService pricingService = new PricingService();

            // Act
            var resutl = pricingService.GetCustomerProductPrice(isUserLoggedIn, orgDiscount, product);

            // Assert
            Assert.AreEqual(expectedResult, resutl);
        }

        [TestMethod]
        public void GetCustomerProductPrice_Scenario6()
        {
            // Arrange
            decimal? expectedResult = 30.50m;

            bool isUserLoggedIn = true;
            decimal orgDiscount = 15;
            var product = new Product
            {
                Price = 36.00m,
                OnlineDiscount = true,
                MaxDiscount = 14
            };

            IPricingService pricingService = new PricingService();

            // Act
            var resutl = pricingService.GetCustomerProductPrice(isUserLoggedIn, orgDiscount, product);

            // Assert
            Assert.AreEqual(expectedResult, resutl);
        }
    }
}
