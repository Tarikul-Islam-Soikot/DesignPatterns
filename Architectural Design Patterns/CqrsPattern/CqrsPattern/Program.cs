using Microsoft.Extensions.DependencyInjection;
using MediatR;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using CqrsPattern.Request;
using CqrsPattern;

var host = Host.CreateDefaultBuilder()
    .ConfigureServices((hostContext, services) => 
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
    })
    .Build();

var serviceProvider = host.Services;
var mediator = serviceProvider.GetRequiredService<IMediator>();

CreateOrderCommand createCommand = new CreateOrderCommand() { Name = "Dummy Product" };
GetOrderQuery getQuery = new GetOrderQuery() { Id = 1 };

var result = await mediator.Send(createCommand);
var result1 = await mediator.Send(getQuery);
