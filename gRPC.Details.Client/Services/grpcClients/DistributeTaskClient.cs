using gRPC.Details.Server.Protos.DistributeTask;
using Grpc.Net.Client;

namespace gRPC.Details.Client.Services.grpcClients
{
    public class DistributeTaskClient : BackgroundService
    {
        private DistributeTaskService.DistributeTaskServiceClient _client;


        protected DistributeTaskService.DistributeTaskServiceClient Client
        {
            get
            {
                if (this._client == null)
                {
                    var channel = GrpcChannel.ForAddress("");
                    this._client = new DistributeTaskService.DistributeTaskServiceClient(channel);
                }
                return this._client;
            }
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var task = new AddedTask();
            var result = await Client.AddTaskAsync(task);
        }
    }
}
