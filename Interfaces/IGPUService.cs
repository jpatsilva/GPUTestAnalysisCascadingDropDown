using GPUTestAnalysisCascadingDropDown.Dtos;

namespace GPUTestAnalysisCascadingDropDown.Interfaces
{
    public interface IGPUService
    {
        IEnumerable<GPUReturnDto> GetGPUByType(string type);
    }
}
