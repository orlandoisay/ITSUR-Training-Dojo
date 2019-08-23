using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITSURTrainingDOJO.Web.ActionFilters
{
    public class LoginRequired : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session["logged"] == null)
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
        }
    }
}