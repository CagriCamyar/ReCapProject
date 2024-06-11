using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColourManager : IColourService
    {
        IColourDal _colourDal;

        public ColourManager(IColourDal colourDal)
        {
            _colourDal = colourDal;
        }

        public IResult Add(Colour colour)
        {
            _colourDal.Add(colour);
            return new SuccessResult(Messages.ColourAdded);
        }

        public IResult Delete(Colour colour)
        {
            _colourDal.Delete(colour);
            return  new SuccessResult(Messages.ColourDeleted);
        }

        public IDataResult<List<Colour>> GetAll()
        {
            return new SuccessDataResult<List<Colour>>(_colourDal.GetAll(), Messages.ColoursListed);
        }

        public IDataResult<Colour> GetById(int colourId)
        {
            return new SuccessDataResult<Colour>(_colourDal.Get(cl=> cl.ColourId == colourId), Messages.GetColour);
        }

        public IResult Update(Colour colour)
        {
            _colourDal.Update(colour);
            return new SuccessResult(Messages.ColourUpdated);
        }      
    }
}
