using KodlamaioDemo.DataAccess;
using KodlamaioDemo.DataAccess.Abstracts;
using KodlamaioDemo.DataAccess.Concretes;
using KodlamaioDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.Business
{
    public class CategoryManager
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll() 
        {
            return _categoryDal.GetAll();
        }
    }
}
