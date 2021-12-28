using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abc.Core.DataAccess.EntityFremework;
using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.Entities.Concrete;

namespace Abc.Northwind.DataAccess.Concrete.EntityFremework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {

    }
}
