using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business.Abstract
{
    public interface ICategoriesService
    {
        IDataResult<List<Categories>> GetList();

        IDataResult<Categories> GetById(int productId);
        IDataResult<List<Categories>> GetListByCategory(int categoryId);

        IResult Add(Categories categories);
        IResult Delete(Categories categories);
        IResult Update(Categories categories);
    }
}
