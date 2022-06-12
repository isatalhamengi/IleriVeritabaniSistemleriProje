using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IClassRoomService
    {
        IDataResult<List<ClassRoom>> GetAll();
        IResult Add(ClassRoom classRoom);
        IResult Remove(ClassRoom classRoom);
        IResult Update(ClassRoom classRoom);
    }
}
