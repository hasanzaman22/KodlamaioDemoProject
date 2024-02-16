using KodlamaioDemo.DataAccess.Abstracts;
using KodlamaioDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> categories;

        public CategoryDal()
        {
            Category category1 = new Category() 
            {
                Id = 1,
                CategoryId = 1,
                CategoryName = "Programlama"
            };

            categories = new List<Category>() { category1 };
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public void Add(Category category)
        {
            categories.Add(category);
            Console.WriteLine("Category Added.");
        }

        public void Delete(Category category)
        {
            categories.Remove(category);
            Console.WriteLine("Category Deleted");
        }

        public void Update(Category category)
        {
            Console.WriteLine("Category Updated.");
        }
    }
}
