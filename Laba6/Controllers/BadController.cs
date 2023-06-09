using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

namespace Laba6.Controllers
{
    public class BadController : IController
    {
        public void Execute(RequestContext requestContext)
        {
            if (requestContext.RouteData.Values["action"].ToString() == "start" && requestContext.RouteData.Values["id"].ToString() == "0")
            {
                requestContext.HttpContext.Response.Redirect("/my/index", true);
            }
            else
            {
                requestContext.HttpContext.Response.Write("Невергые параметры ввода" + "<br/>" + requestContext.HttpContext.Request.Url);
            }
        }
    }
}
