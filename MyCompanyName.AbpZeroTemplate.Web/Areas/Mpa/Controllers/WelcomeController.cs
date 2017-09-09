using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using xtWork.Template.Web.Controllers;

namespace xtWork.Template.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class WelcomeController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}