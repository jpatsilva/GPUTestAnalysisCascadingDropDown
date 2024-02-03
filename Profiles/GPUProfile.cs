using AutoMapper;
using GPUTestAnalysisCascadingDropDown.Dtos;
using GPUTestAnalysisCascadingDropDown.Models;

namespace GPUTestAnalysisCascadingDropDown.Profiles
{
    public class GPUProfile : Profile
    {
        public GPUProfile()
        {
            CreateMap<GPU, GPUDto>();
        }
    }
}
