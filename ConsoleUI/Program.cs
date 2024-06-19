using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System.Net.Security;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Results();
            if (DateTime.Now.Minute == 19)
            {
                Console.WriteLine("Selam");

            }
            else
            {
                Console.WriteLine("As");
            }

            //    CarManager carManager = new CarManager(new EfCarDal());

            //    var result = carManager.GetCarDetails();

            //    if (result.Success == true)
            //    {
            //        Console.WriteLine(Messages.CarsListed);
            //        foreach (var car in result.Data)
            //        {                   
            //            Console.WriteLine(car.Description);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(result.Message);
            //    }


            //foreach (CarDetailDto carDetailDto in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(carDetailDto.CarId + "/" + carDetailDto.BrandName + "/" + carDetailDto.ColourName + "/" + carDetailDto.Description);
            //}


            //CarManager carManager = new CarManager(new EfCarDal());

            //foreach (Car car in carManager.GetCarsByBrandId(2))
            //{
            //    Console.WriteLine(car.Description);
            //}

            //Console.WriteLine("\n NameMinTwoChars : ");

            //carManager.NameMinTwoChars(new Car
            //{
            //    BrandId = 7,
            //    ColourId = 3,
            //    DailyPrice = 700,
            //    ModelYear = 2018,
            //    Description = "Renault Clio White",
            //});

            // Console.WriteLine("\nDailyPriceMoreThanZero : ");

            // carManager.DailyPriceMoreThanZero(new Car
            // {
            //     CarId = 16,
            //     BrandId = 8,
            //     ColourId = 1,
            //     DailyPrice = 1000,
            //     ModelYear = 2023,
            //     Description = "Chevrolet Captiva Black",
            // });
        }

        private static void Results()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            var result = customerManager.GetCustomerDetails();
            if (result.Success)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + customer.CompanyName + " " + customer.Email + " " + customer.Password);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}