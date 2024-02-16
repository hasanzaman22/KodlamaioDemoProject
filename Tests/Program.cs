using KodlamaioDemo.Business;
using KodlamaioDemo.DataAccess.Concretes;
using KodlamaioDemo.Entities;

CourseManager courseManager = new(new CourseDal());
CategoryManager categoryManager = new(new CategoryDal());
InstructorManager instructorManager = new(new InstructorDal());

List<Course> course = courseManager.GetAll();
List<Category> category = categoryManager.GetAll();
List<Instructor> instructor = instructorManager.GetAll();

foreach (var c in course)
{
    foreach (var cat in category)
    {
        foreach (var i in instructor)
        {
            if (c.InstructorId == i.InstructorId && c.CategoryId == cat.CategoryId)
            {
                Console.WriteLine(c.Title + "\nDescription - " + c.Description + "\nCategory - " + cat.CategoryName + "\nInstructor - " + i.FirstName + " " + i.LastName);
                Console.WriteLine("---------------------------------------------------------------------");
            }
        }


    }
}