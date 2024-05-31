using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId (int id);
        IDataResult<List<Car>> GetCarsByColourId (int id);
        IDataResult<List<Car>> GetByDailyPrice (decimal min, decimal max);
        IResult NameMinTwoChars(Car car);
        IResult DailyPriceMoreThanZero(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add(Car car);
    }
}