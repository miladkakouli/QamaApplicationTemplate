using $ext_safeprojectname$.Commands.Commands;
using Qama.Framework.Application.Abstractions;

namespace $safeprojectname$.DTOs
{
    public class TestCommandDto : IInputDtoCommand<TestCommand>
    {
        public string Ssn { get; set; }
        public TestCommand ToCommand()
        {
            return new TestCommand(Ssn);
        }
    }
}
