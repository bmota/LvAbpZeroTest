using Abp.Authorization;
using xtWork.Template.Authorization.Roles;
using xtWork.Template.Authorization.Users;
using xtWork.Template.MultiTenancy;

namespace xtWork.Template.Authorization
{
    /// <summary>
    /// Implements <see cref="PermissionChecker"/>.
    /// </summary>
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
