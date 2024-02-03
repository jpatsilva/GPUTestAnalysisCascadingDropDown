using GPUTestAnalysisCascadingDropDown.Models;

namespace GPUTestAnalysisCascadingDropDown.Utilities
{
    public class GPUUtility
    {
        private readonly IConfiguration _configuration;
        private string _connectionString;
        private string _getGPUByType;

        public GPUUtility(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DataContext");
            _getGPUByType - _configuration.GetSection("GPUServiceQueries").GetSection("GetGPUByType").Value;
        }

        public List<GPUReturnDto> GetGPUByType(string? type) 
        {
            List<GPU> gpus = new();


        }
    }
}
