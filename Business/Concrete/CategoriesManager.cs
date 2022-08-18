using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.Concrete.Contants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoriesManager: ICategoriesService
    {
        private ICategoriesDal _categoriesDal;

        public CategoriesManager(ICategoriesDal categoriesDal)
        {
            _categoriesDal = categoriesDal;
        }

        public IDataResult<Categories> GetById(int categoryId)
        {
            return new SuccessDataResult<Categories>(_categoriesDal.Get(filter: p => p.CategoryID == categoryId));
        }
        public IDataResult<List<Categories>> GetList()
        {
            return new SuccessDataResult<List<Categories>>(_categoriesDal.GetList().ToList());
        }

        public IDataResult<List<Categories>> GetListByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Categories>>(_categoriesDal.GetList(filter: p => p.CategoryID == categoryId).ToList());
        }
        public IResult Add(Categories categories)
        {
            _categoriesDal.Add(categories);
            return new SuccessResult(message: Messages.ProductAdded);

        }
        public IResult Delete(Categories categories)
        {
            _categoriesDal.Delete(categories);
            return new SuccessResult(message: Messages.ProductDeleted);

        }
        public IResult Update(Categories categories)
        {
            _categoriesDal.Update(categories);
            return new SuccessResult(message: Messages.ProductUpdated);

        }



    }
}
