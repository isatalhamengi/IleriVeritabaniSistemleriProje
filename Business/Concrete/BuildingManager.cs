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
    public class BuildingManager : IBuildingService
    {
        IBuildingDal _buildingDal;

        public BuildingManager(IBuildingDal buildingDal)
        {
            _buildingDal = buildingDal;
        }

        public IResult Add(Building building)
        {
            _buildingDal.Add(building);
            return new SuccessResult();
        }

        public IDataResult<List<Building>> GetAll()
        {
            return new SuccessDataResult<List<Building>>(_buildingDal.GetAll());
        }

        public IResult Remove(Building building)
        {
            _buildingDal.Delete(building);
            return new SuccessResult();
        }

        public IResult Update(Building building)
        {
            _buildingDal.Update(building);
            return new SuccessResult();
        }
    }
}
