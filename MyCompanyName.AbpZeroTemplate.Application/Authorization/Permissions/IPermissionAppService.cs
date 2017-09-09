using Abp.Application.Services;
using Abp.Application.Services.Dto;
using xtWork.Template.Authorization.Permissions.Dto;

namespace xtWork.Template.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
