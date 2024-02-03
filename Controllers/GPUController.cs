using AutoMapper;
using GPUTestAnalysisCascadingDropDown.Interfaces;

namespace GPUTestAnalysisCascadingDropDown.Controllers
{
    public class GPUController
    {
        private readonly IConfiguration _configuration;
        private IGPUService _gpuService;
        IMapper _mapper;
        private readonly string _connectionString;

        public GPUController(IConfiguration configuration, IGPUService gpuService, IMapper mapper, string connectionString)
        {
            _configuration = configuration;
            _gpuService = gpuService;
            _mapper = mapper;
            _connectionString = connectionString;
        }
    }
}
