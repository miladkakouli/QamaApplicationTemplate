using Qama.Framework.Application.Abstractions;
using $ext_safeprojectname$.Queries.Queries;

namespace $safeprojectname$.DTOs
{
    public class TestQueryDto : IInputDtoQuery<TestQuery>
    {
        public string Ssn { get; set; }

        public TestQuery ToQuery()
        {
            return new TestQuery(Ssn);
        }
    }
}
