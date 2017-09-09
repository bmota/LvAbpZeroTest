using System.Threading.Tasks;
using Abp.Application.Services;
using xtWork.Template.Sessions.Dto;

namespace xtWork.Template.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
