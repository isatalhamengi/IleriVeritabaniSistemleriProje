using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITeacherService
    {
        IDataResult<List<Teacher>> GetAll();
        IResult Add(Teacher teacher);
        IResult Remove(Teacher teacher);
        IResult Update(Teacher teacher);
    }
}
