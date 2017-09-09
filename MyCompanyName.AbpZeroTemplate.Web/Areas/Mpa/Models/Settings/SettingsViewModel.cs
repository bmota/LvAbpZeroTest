using System.Collections.Generic;
using Abp.Application.Services.Dto;
using xtWork.Template.Configuration.Tenants.Dto;

namespace xtWork.Template.Web.Areas.Mpa.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}