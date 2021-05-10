using Microsoft.AspNetCore.Mvc;
using $ext_safeprojectname$.Commands.Commands;
using Qama.Framework.Application.Abstractions;
using Qama.Framework.Core.Abstractions.Commands;
using $safeprojectname$.DTOs;

namespace $safeprojectname$.Controllers
{
    [Route("[controller]")]

    public class TestCommandController : CommandControllerBase<TestCommand, TestCommandDto>
    {
        public TestCommandController(ICommandBus bus) : base(bus)
        {
        }
    }
}
