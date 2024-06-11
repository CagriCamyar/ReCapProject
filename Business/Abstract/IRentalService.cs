using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int rentalId);
        IDataResult<Rental> GetRentalByCarID(int carId);
        IDataResult<Rental> GetRentalByUserID(int userId);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
    }
}
