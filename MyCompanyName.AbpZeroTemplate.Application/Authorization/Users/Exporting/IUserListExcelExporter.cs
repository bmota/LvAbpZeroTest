using System.Collections.Generic;
using xtWork.Template.Authorization.Users.Dto;
using xtWork.Template.Dto;

namespace xtWork.Template.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}