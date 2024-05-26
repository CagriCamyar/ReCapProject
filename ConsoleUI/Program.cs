using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());

            foreach (CarDetailDto carDetailDto in carManager.GetCarDetails())
            {
                Console.WriteLine(carDetailDto.CarId + "/" + carDetailDto.BrandName + "/" + carDetailDto.ColourName + "/" + carDetailDto.Description);
            }


            // CarManager carManager = new CarManager(new EfCarDal());

            // foreach (Car car in carManager.GetCarsByBrandId(2))
            // {
            //     Console.WriteLine(car.Description);
            // }

            //Console.WriteLine("\n NameMinTwoChars : ");

            // carManager.NameMinTwoChars(new Car
            // {
            //            BrandId = 7,
            //            ColourId =3,
            //            DailyPrice = 700,
            //            ModelYear = 2018,
            //           Description = "Renault Clio White",
            // });

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
    }
}