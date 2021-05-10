using Microsoft.Extensions.DependencyInjection;
using $safeprojectname$.CommandHandlers;
using $safeprojectname$.Commands;
using Qama.Framework.Core.CommandBus.InMemory;
using Qama.Framework.Core.EventBus.RabbitMQ;
using Qama.Framework.Extensions.Microsoft.DependencyInjection;

namespace $safeprojectname$
{
    public static class Startup
    {
        public static void WireUp(this IServiceCollection services)
        {
            services.AddCommandBus<InMemoryCommandBus>();
            services.AddEventBus<RabbitMQEventBus>();
            services.AddCommandHandlerWithValidationalAndTransactionalDecorator<TestCommand, TestCommandHandler>();
        }
    }
}
