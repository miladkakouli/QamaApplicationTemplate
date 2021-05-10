using System;
using System.Threading.Tasks;
using $safeprojectname$.Commands;
using $ext_safeprojectname$.Events.Events;
using Qama.Framework.Core.Abstractions.Commands;
using Qama.Framework.Core.Abstractions.Events;
using Qama.Framework.Core.Abstractions.Logging;
using Qama.Framework.Core.Abstractions.Persistence;
using Qama.Framework.Core.Abstractions.ServiceLocator;
using Qama.Framework.Core.EventBus.RabbitMQ;
using $ext_safeprojectname$.Persistence.Entities;

namespace $safeprojectname$.CommandHandlers
{
    class TestCommandHandler : ICommandHandler<TestCommand>
    {
        private readonly IEverythingLogger _logger;
        private readonly IRepository<TestEntity, Guid> _repository;
        private readonly IServiceLocator _serviceLocator;
        public TestCommandHandler(IEverythingLogger logger, IRepository<TestEntity, Guid> repository
            , IServiceLocator serviceLocator)
        {
            _logger = logger;
            _repository = repository;
            _serviceLocator = serviceLocator;
        }
        public Task Handle(TestCommand command)
        {
            _logger.LogInformation("This is How to Write Log Everywhere");
            var entity = new TestEntity(command.Ssn);
            _repository.Add(entity);
            return Task.CompletedTask;
        }

    }
}
