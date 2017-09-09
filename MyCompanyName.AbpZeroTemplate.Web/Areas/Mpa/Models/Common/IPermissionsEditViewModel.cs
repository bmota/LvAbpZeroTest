using System.Collections.Generic;
using xtWork.Template.Authorization.Permissions.Dto;

namespace xtWork.Template.Web.Areas.Mpa.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}