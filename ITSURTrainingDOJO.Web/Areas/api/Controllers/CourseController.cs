using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using ITSURTrainingDOJO.Web.ActionFilters;
using ITSURTrainingDOJO.Web.Areas.api.Models;
using ITSURTrainingDOJO.Web.Areas.api.Repositories;
using Newtonsoft.Json;

namespace ITSURTrainingDOJO.Web.Areas.api.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository courseRepository;

        public CourseController(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }

        [LoginRequired]
        [HttpGet]
        public JsonResult Get(int id = 5)
        {
            var course = courseRepository.GetById(id);
            return Json(course, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult All()
        {
            var courses = courseRepository.GetAll();
            return Json(courses, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Add(Course course)
        {
            var result = courseRepository.Add(course);
            return Json(new {
                Status = "ok",
                Result = result,
            }, JsonRequestBehavior.AllowGet);
        }
    }
}