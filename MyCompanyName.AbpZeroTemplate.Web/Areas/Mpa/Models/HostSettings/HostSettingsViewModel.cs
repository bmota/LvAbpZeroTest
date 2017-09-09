using System.Collections.Generic;
using Abp.Application.Services.Dto;
using xtWork.Template.Configuration.Host.Dto;

namespace xtWork.Template.Web.Areas.Mpa.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<ComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}