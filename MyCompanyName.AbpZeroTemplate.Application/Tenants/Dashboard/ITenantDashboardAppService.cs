using Abp.Application.Services;
using xtWork.Template.Tenants.Dashboard.Dto;

namespace xtWork.Template.Tenants.Dashboard
{
    public interface ITenantDashboardAppService : IApplicationService
    {
        GetMemberActivityOutput GetMemberActivity();
    }
}
