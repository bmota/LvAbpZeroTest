﻿using System.Web.Mvc;
using Abp.Auditing;
using Abp.Web.Mvc.Authorization;
using xtWork.Template.Authorization;
using xtWork.Template.Web.Controllers;

namespace xtWork.Template.Web.Areas.Mpa.Controllers
{
    [DisableAuditing]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_AuditLogs)]
    public class AuditLogsController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}