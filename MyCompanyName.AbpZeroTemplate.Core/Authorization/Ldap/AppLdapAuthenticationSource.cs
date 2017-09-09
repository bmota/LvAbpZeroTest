using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using xtWork.Template.Authorization.Users;
using xtWork.Template.MultiTenancy;

namespace xtWork.Template.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}
