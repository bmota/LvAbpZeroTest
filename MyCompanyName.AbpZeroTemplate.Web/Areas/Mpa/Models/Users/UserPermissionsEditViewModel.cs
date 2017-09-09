using Abp.AutoMapper;
using xtWork.Template.Authorization.Users;
using xtWork.Template.Authorization.Users.Dto;
using xtWork.Template.Web.Areas.Mpa.Models.Common;

namespace xtWork.Template.Web.Areas.Mpa.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; private set; }

        public UserPermissionsEditViewModel(GetUserPermissionsForEditOutput output, User user)
        {
            User = user;
            output.MapTo(this);
        }
    }
}