using Microsoft.Extensions.DependencyInjection;
using $ext_safeprojectname$.Commands.Commands;
using Qama.Framework.Extensions.Microsoft.DependencyInjection;
using $ext_safeprojectname$.Queries.Queries;
using $safeprojectname$.Validators;

namespace $safeprojectname$
{
    public static class Startup
    {
        public static void WireUp(this IServiceCollection services)
        {
            services.AddValidator<TestQuery, TestQueryValidator>();
            services.AddValidator<TestCommand, TestCommandValidator>();
        }
    }
}
