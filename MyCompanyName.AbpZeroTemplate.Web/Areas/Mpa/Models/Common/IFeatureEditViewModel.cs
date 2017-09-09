using System.Collections.Generic;
using Abp.Application.Services.Dto;
using xtWork.Template.Editions.Dto;

namespace xtWork.Template.Web.Areas.Mpa.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}