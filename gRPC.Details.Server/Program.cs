using gRPC.Details.Server.Services.gRPC;
using gRPC.Details.Service.Application.DependencyInjection;
using gRPC.Details.Service.Persistance.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddPersistance(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddGrpc();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGrpcService<DistributeTaskGRPC>();

app.Run();
