using System.Collections.Generic;
using xtWork.Template.Caching.Dto;

namespace xtWork.Template.Web.Areas.Mpa.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}