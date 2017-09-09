using System.Collections.Generic;
using xtWork.Template.Auditing.Dto;
using xtWork.Template.Dto;

namespace xtWork.Template.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
