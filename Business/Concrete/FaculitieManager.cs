using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FaculitieManager : IFaculitieService
    {
        IFaculitieDal _faculitiedal;

        public FaculitieManager(IFaculitieDal faculitiedal)
        {
            _faculitiedal = faculitiedal;
        }

        public IResult Add(Faculitie faculitie)
        {
           _faculitiedal.Add(faculitie);
            return new SuccessResult();
        }

        public IDataResult<List<Faculitie>> GetAll()
        {
            return new SuccessDataResult<List<Faculitie>>(_faculitiedal.GetAll());
        }

        public IResult Remove(Faculitie faculitie)
        {
            _faculitiedal.Delete(faculitie);
            return new SuccessResult();
        }

        public IResult Update(Faculitie faculitie)
        {
            _faculitiedal.Update(faculitie);
            return new SuccessResult();
        }
    }
}
