using AutoMapper;
using gRPC.Details.Client.Application.Contracts;

namespace gRPC.Details.Client.Application.Features.Common
{
    internal class QueryBase
    {
        protected readonly IServiceDbContext _context;
        protected readonly IMapper _mapper;

        internal QueryBase(IServiceDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
