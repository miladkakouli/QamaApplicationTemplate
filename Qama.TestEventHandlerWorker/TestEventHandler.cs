using System;
using System.Threading.Tasks;
using $ext_safeprojectname$.Events.Events;
using Qama.Framework.Core.Abstractions.Events;

namespace $safeprojectname$
{
    public class TestEventHandler : IEventHandler<TestEvent>
    {
        public TestEventHandler()
        { }
        public Task Handle(TestEvent @event)
        {
            throw new NotImplementedException();
        }
    }
}
