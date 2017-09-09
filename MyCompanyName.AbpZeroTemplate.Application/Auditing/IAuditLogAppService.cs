using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using xtWork.Template.Auditing.Dto;
using xtWork.Template.Dto;

namespace xtWork.Template.Auditing
{
    public interface IAuditLogAppService : IApplicationService
    {
        Task<PagedResultDto<AuditLogListDto>> GetAuditLogs(GetAuditLogsInput input);

        Task<FileDto> GetAuditLogsToExcel(GetAuditLogsInput input);
    }
}