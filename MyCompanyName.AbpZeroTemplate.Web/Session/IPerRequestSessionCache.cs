using System.Threading.Tasks;
using xtWork.Template.Sessions.Dto;

namespace xtWork.Template.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
