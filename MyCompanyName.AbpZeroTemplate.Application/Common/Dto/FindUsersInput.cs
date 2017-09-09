using xtWork.Template.Dto;

namespace xtWork.Template.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}