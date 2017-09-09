using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using xtWork.Template.Web.Areas.Mpa.Models.Common.Modals;
using xtWork.Template.Web.Controllers;

namespace xtWork.Template.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class CommonController : AbpZeroTemplateControllerBase
    {
        public PartialViewResult LookupModal(LookupModalViewModel model)
        {
            return PartialView("Modals/_LookupModal", model);
        }
    }
}