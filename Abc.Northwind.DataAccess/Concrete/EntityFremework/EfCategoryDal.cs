using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Abc.Core.DataAccess.EntityFremework;
using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.Entities.Concrete;

namespace Abc.Northwind.DataAccess.Concrete.EntityFremework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
        public Category Get(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetList(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}