using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{ 
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void DailyPriceMoreThanZero(Car car)
        {
            if (car.DailyPrice >0)
            {
                _carDal.Add(car);
                Console.WriteLine("New Car Added!");
            }
            else
            {
                Console.WriteLine("Wants to Added Car's Daily Price needs to more than 0 liras.");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c=> c.BrandId == id);
        }

        public List<Car> GetCarsByColourId(int id)
        {
            return _carDal.GetAll(c=> c.ColourId == id);
        }

        public void NameMinTwoChars(Car car)
        {
            if (car.Description.Length >= 2)
            {
                _carDal.Add(car);
                Console.WriteLine("New Car Added!");
            }
            else
            {
                Console.WriteLine("Added Car Name needs to minimum 2 characters.");
            }
        }
    }
}
