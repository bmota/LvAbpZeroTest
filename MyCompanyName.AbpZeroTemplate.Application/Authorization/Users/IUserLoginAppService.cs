using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using xtWork.Template.Authorization.Users.Dto;

namespace xtWork.Template.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
