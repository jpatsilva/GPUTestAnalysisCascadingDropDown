using GPUTestAnalysisCascadingDropDown.Dtos;

namespace GPUTestAnalysisCascadingDropDown.Interfaces
{
    public interface IGPUService
    {
        IEnumerable<GPUDto> GetGPUByType(Type type);
    }
}
