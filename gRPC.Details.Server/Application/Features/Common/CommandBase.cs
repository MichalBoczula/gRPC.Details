using AutoMapper;
using gRPC.Details.Service.Application.Contracts;

namespace gRPC.Details.Service.Application.Features.Common
{
    internal class CommandBase
    {
        protected readonly IServiceDbContext _context;
        protected readonly IMapper _mapper;

        internal CommandBase(IServiceDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
