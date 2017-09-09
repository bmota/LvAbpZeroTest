using Abp.AutoMapper;
using xtWork.Template.MultiTenancy;
using xtWork.Template.MultiTenancy.Dto;
using xtWork.Template.Web.Areas.Mpa.Models.Common;

namespace xtWork.Template.Web.Areas.Mpa.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesForEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesForEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }

        public TenantFeaturesEditViewModel(Tenant tenant, GetTenantFeaturesForEditOutput output)
        {
            Tenant = tenant;
            output.MapTo(this);
        }
    }
}