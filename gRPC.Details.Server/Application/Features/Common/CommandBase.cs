using AutoMapper;
using gRPC.DeepDive.Service.Application.Contracts;

namespace gRPC.DeepDive.Service.Application.Features.Common
{
    public class CommandBase
    {
        protected readonly IServiceDbContext _context;
        protected readonly IMapper _mapper;

        public CommandBase(IServiceDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
