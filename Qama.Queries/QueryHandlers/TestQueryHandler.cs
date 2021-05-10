using System.Data;
using System.Threading.Tasks;
using Dapper;
using Qama.Framework.Core.Abstractions.Queries;
using $safeprojectname$.Queries;
using $safeprojectname$.QueryResults;

namespace $safeprojectname$.QueryHandlers
{
    class TestQueryHandler : IQueryHandler<TestQuery>
    {
        private readonly IDbConnection _dbConnection;
        public TestQueryHandler(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public async Task<IQueryResult> Handle(TestQuery query)
        {
            return new TestQueryResult
            {
                List = await _dbConnection.QueryAsync<resultDto>("Select * from [TestEntitys]")
            };
        }
    }
}
