using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using xtWork.Template.Authorization.Users;

namespace xtWork.Template.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}