using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using xtWork.Template.Authorization;
using xtWork.Template.Web.Controllers;

namespace xtWork.Template.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class DashboardController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}