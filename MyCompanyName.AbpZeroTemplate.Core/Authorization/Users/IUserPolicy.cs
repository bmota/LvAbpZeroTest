using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace xtWork.Template.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
