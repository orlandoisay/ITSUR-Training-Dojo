using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ITSURTrainingDOJO.Web.Areas.api.Models;

namespace ITSURTrainingDOJO.Web.Areas.api.Repositories
{
    public class CourseMockRepository : ICourseRepository
    {
        private readonly Course[] list = new Course[]
        {
            new Course
            {
                Id = 1,
                Name = "ITSUR Avanzado",
                Description = "Lorem ipsum dolor sit amet...",
                AuthorId = -1,
                CreationDate = DateTime.Now,
            },
            new Course
            {
                Id = 2,
                Name = "ITSUR Basico",
                Description = "Lorem ipsum dolor sit amet...",
                AuthorId = -1,
                CreationDate = DateTime.Now.AddDays(-20),
            },
            new Course
            {
                Id = 3,
                Name = "CBTIS",
                Description = "Lorem ipsum dolor sit amet...",
                AuthorId = -1,
                CreationDate = DateTime.Now.AddDays(-10),
            },
        };

        public Course Add(Course course)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetAll()
        {
            return list;
        }

        public Course GetById(int id)
        {
            return list.Where(course => course.Id == id).FirstOrDefault();
        }

        public Course Update(Course course)
        {
            throw new NotImplementedException();
        }
    }
}