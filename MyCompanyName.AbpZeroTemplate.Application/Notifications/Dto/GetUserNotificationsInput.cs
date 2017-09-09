using Abp.Notifications;
using xtWork.Template.Dto;

namespace xtWork.Template.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}