using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal 
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
              new Car {CarId = 1,  BrandId = 1, ColourId = 1, DailyPrice = 750, ModelYear = 2017, Description = "Fiat Egea Sedan" },
              new Car {CarId = 2,  BrandId = 2, ColourId = 2, DailyPrice = 800, ModelYear = 2020, Description = "Opel Corsa Hatchback " },
              new Car {CarId = 3,  BrandId = 2, ColourId = 1, DailyPrice = 600, ModelYear = 2014, Description = "Opel " },
              new Car {CarId = 4,  BrandId = 3, ColourId = 3, DailyPrice = 1500, ModelYear = 2022, Description = "Mini Cooper" },
              new Car {CarId = 5,  BrandId = 1, ColourId = 5, DailyPrice = 450, ModelYear = 2005, Description = "Fiat Palio" },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault (c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(long nationalityid)
        {
            return _cars.Where(c => c.Equals(nationalityid)).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault (c=> c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColourId = car.ColourId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
