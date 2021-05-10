using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using $ext_safeprojectname$.Events.Events;
using Qama.Framework.Core.Abstractions.Events;
using Qama.Framework.Core.Abstractions.ServiceLocator;

namespace $safeprojectname$
{
    class TestEventWorker
    {
        private IServiceLocator _locator;
        private IEventHandler<TestEvent> _eventHandler;
        public TestEventWorker(IServiceLocator locator)
        {
            _locator = locator;
        }
        public void Start()
        {
            _eventHandler = _locator.GetInstance<IEventHandler<TestEvent>>();
        }

        public void Stop()
        {
            _locator.Release(_eventHandler);
        }
    }
}
