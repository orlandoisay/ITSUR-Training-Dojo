using ITSURTrainingDOJO.Web.Areas.api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITSURTrainingDOJO.Web.Areas.api.Repositories
{
    public interface ICourseRepository
    {
        Course GetById(int id);
        IEnumerable<Course> GetAll();
        Course Add(Course course);
        Course Update(Course course);
    }
}