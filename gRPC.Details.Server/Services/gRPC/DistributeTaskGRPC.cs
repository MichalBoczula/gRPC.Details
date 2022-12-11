using gRPC.Details.Server.Protos.DistributeTask;
using Grpc.Core;

namespace gRPC.Details.Server.Services.gRPC
{
    public class DistributeTaskGRPC : DistributeTaskService.DistributeTaskServiceBase
    {
        public override Task<AddedTaskResult> AddTask(AddedTask request, ServerCallContext context)
        {
            return base.AddTask(request, context);
        }
    }
}
