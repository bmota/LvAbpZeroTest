using Abp.Application.Services;
using xtWork.Template.Dto;
using xtWork.Template.Logging.Dto;

namespace xtWork.Template.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
