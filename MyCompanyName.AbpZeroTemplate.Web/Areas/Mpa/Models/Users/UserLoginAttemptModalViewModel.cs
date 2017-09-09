using System.Collections.Generic;
using xtWork.Template.Authorization.Users.Dto;

namespace xtWork.Template.Web.Areas.Mpa.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}