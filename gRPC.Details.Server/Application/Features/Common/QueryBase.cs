using AutoMapper;
using gRPC.Details.Service.Application.Contracts;

namespace gRPC.Details.Service.Application.Features.Common
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
