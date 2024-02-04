using GPUTestAnalysisCascadingDropDown.Dtos;
using GPUTestAnalysisCascadingDropDown.Models;
using System.ComponentModel;
using System.Linq.Expressions;

namespace GPUTestAnalysisCascadingDropDown.Utilities
{
    public class GPUUtility
    {
        private readonly IConfiguration _configuration;
        private string? _connectionString;
        private string? _getGPUByType;

        public GPUUtility(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DataContext");
            _getGPUByType = _configuration.GetSection("GPUServiceQueries").GetSection("GetGPUByType").Value;
        }

        public List<GPUReturnDto> GetGPUByType(string? type) 
        {
            List<GPU> gpus = new();

            using (dbContext db = new dbContext())
            {
                gpus = db.GPUs.Where(x => x.Type == type).ToList();
            }

            var queryGPU =
                from gpu in gpus
                where gpu != null
                select new GPUReturnDto
                {
                    Type = gpu.Type,
                    Parameter = gpu.Parameter_Name,
                    Expression = gpu.Expression,
                    Description = gpu.Description
                };

            List<GPUReturnDto> foundGPUTypes = new();

            foreach (var gpu in queryGPU) 
            {
                foundGPUTypes.Add(gpu);
            }

            return foundGPUTypes;
        }
    }
}
