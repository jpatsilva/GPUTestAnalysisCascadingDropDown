using AutoMapper;
using GPUTestAnalysisCascadingDropDown.Dtos;
using GPUTestAnalysisCascadingDropDown.Interfaces;
using GPUTestAnalysisCascadingDropDown.Models;

namespace GPUTestAnalysisCascadingDropDown.Controllers
{
    public class GPUController
    {
        private readonly IConfiguration _configuration;
        private IGPUService _gpuService;
        IMapper _mapper;
        private readonly string? _connectionString;

        public GPUController(IConfiguration configuration, IGPUService gpuService, IMapper mapper)
        {
            _configuration = configuration;
            _gpuService = gpuService;
            _mapper = mapper;
            _connectionString = ConfigurationExtensions.GetConnectionString(_configuration, "DataContext");
        }

        public IEnumerable<GPU> GetGPUByType(string type) 
        {
            IEnumerable<GPUReturnDto> gpus = new List<GPUReturnDto>();
            List<GPUReturnDto> gpuDtos = new();

            gpus = _gpuService.GetGPUByType(type);
            gpuDtos = _mapper.Map<List<GPUReturnDto>>(gpus);

            return (IEnumerable<GPU>)gpuDtos;
        }
    }
}
