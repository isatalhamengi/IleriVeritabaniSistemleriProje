using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ClassRoomManager : IClassRoomService
    {
        public IResult Add(ClassRoom classRoom)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ClassRoom>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Remove(ClassRoom classRoom)
        {
            throw new NotImplementedException();
        }

        public IResult Update(ClassRoom classRoom)
        {
            throw new NotImplementedException();
        }
    }
}
