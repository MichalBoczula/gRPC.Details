using AutoMapper;
using gRPC.DeepDive.Service.Application.Contracts;

namespace gRPC.DeepDive.Service.Application.Features.Common
{
    public class QueryBase
    {
        protected readonly IServiceDbContext _context;
        protected readonly IMapper _mapper;

        public QueryBase(IServiceDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
