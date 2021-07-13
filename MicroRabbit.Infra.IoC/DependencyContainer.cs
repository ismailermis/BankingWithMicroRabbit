using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegiserServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus,RabbitMQBus>();
        }
    }
}
