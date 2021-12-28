using System.Collections.Generic;
using Abc.Northwind.Entities.Concrete;

namespace Abc.Northwind.MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; internal set; }
        public uint CurrentCategory { get; internal set; }

        public List<Category>
    }
}
