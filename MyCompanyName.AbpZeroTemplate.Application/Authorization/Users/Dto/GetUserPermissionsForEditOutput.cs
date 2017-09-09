using System.Collections.Generic;
using Abp.Application.Services.Dto;
using xtWork.Template.Authorization.Permissions.Dto;

namespace xtWork.Template.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}