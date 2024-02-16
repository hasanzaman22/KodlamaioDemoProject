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
    public class InstructorManager
    {
        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }
    }
}
