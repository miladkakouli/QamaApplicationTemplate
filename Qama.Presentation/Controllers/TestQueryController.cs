using Microsoft.AspNetCore.Mvc;
using Qama.Framework.Application.Abstractions;
using Qama.Framework.Core.Abstractions.Queries;
using $safeprojectname$.DTOs;
using $ext_safeprojectname$.Queries.Queries;

namespace $safeprojectname$.Controllers
{
    [Route("[controller]")]
    public class TestQueryController : QueryControllerBase<TestQuery, TestQueryDto>
    {
        public TestQueryController(IQueryBus bus) : base(bus)
        {
        }
    }
}
