using System.Collections.Generic;
using Abp.Application.Services.Dto;
using xtWork.Template.Authorization.Permissions.Dto;

namespace xtWork.Template.Authorization.Roles.Dto
{
    public class GetRoleForEditOutput
    {
        public RoleEditDto Role { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}