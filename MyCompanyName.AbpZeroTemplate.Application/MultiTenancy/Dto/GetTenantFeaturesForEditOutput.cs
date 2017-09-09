using System.Collections.Generic;
using Abp.Application.Services.Dto;
using xtWork.Template.Editions.Dto;

namespace xtWork.Template.MultiTenancy.Dto
{
    public class GetTenantFeaturesForEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}