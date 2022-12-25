using AutoMapper;
using gRPC.Details.Client.Application.Contracts;

namespace gRPC.Details.Client.Application.Features.Common
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
