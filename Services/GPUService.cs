using GPUTestAnalysisCascadingDropDown.Dtos;
using GPUTestAnalysisCascadingDropDown.Interfaces;
using GPUTestAnalysisCascadingDropDown.Utilities;

namespace GPUTestAnalysisCascadingDropDown.Services
{
    public class GPUService : IGPUService
    {
        private readonly IConfiguration _configuration;
        private GPUUtility _gpuUtility;

        private const string _type = "type";
        private const string _parameter_name = "parameter_name";
        private const string _expression = "expression";
        private const string _description = "description";

        public GPUService(IConfiguration configuration)
        {
            _configuration = configuration;
            _gpuUtility = new(configuration);
        }
        public IEnumerable<GPUReturnDto> GetGPUByType(string type)
        {
            throw new NotImplementedException();
        }
    }
}
