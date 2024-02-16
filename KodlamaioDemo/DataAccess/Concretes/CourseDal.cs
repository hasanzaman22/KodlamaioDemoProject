using KodlamaioDemo.DataAccess.Abstracts;
using KodlamaioDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> courses;

        public CourseDal()
        {

            Course course1 = new Course()
            {
                Id = 1,
                CategoryId = 1,
                CourseId = 1,
                InstructorId = 1,
                Title = "Programlamaya Giriş için Temel Kurs",
                Description = "PYTHON, JAVA, C# gibi tüm programlama dilleri için temel programlama mantığını anlaşılır örneklerle öğrenin."
            };

            Course course2 = new Course()
            {
                Id = 2,
                CategoryId = 1,
                CourseId = 2,
                InstructorId = 1,
                Title = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)",
                Description = ""
            };

            Course course3 = new Course()
            {
                Id = 3,
                CategoryId = 1,
                CourseId = 3,
                InstructorId = 1,
                Title = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)",
                Description = ""
            };

            Course course4 = new Course()
            {
                Id = 4,
                CategoryId = 1,
                CourseId = 4,
                InstructorId = 1,
                Title = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)",
                Description = "1,5 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz."
            };

            Course course5 = new Course()
            {
                Id = 5,
                CategoryId = 1,
                CourseId = 5,
                InstructorId = 1,
                Title = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA",
                Description = "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz."
            };

            Course course6 = new Course()
            {
                Id = 6,
                CategoryId = 1,
                CourseId = 6,
                InstructorId = 2,
                Title = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium",
                Description = "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz."
            };

            Course course7 = new Course()
            {
                Id = 7,
                CategoryId = 1,
                CourseId = 7,
                InstructorId = 1,
                Title = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)",
                Description = "2 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz."
            };

            Course course8 = new Course()
            {
                Id = 8,
                CategoryId = 1,
                CourseId = 8,
                InstructorId = 1,
                Title = "Senior Yazılım Geliştirici Yetiştirme Kampı",
                Description = "Ücretsiz ve profesyonel bir programla, ileri seviye yazılım geliştirme öğreniyoruz."
            };

            courses = new List<Course> { course1, course2, course3, course4, course5, course6, course7, course8 };

        }

        public void Add(Course course)
        {
            courses.Add(course);
            Console.WriteLine("Course Added.");
        }

        public void Delete(Course course)
        {
            courses.Remove(course);
            Console.WriteLine("Course Deleted");
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public void Update(Course course)
        {
            Console.WriteLine("Course Updated.");
        }
    }
}
