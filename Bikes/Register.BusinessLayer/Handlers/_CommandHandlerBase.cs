using Register.BusinessLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.BusinessLayer.Handlers
{
    /// <summary>
    /// abstract class for all command handlers
    /// </summary>
    internal abstract class CommandHandlerBase<TRequest, TResult> : IHandler where TRequest : Command
                                                                             where TResult : CommandResult
    {

        public CommandResult Execute(Command command)
        {
            return ExecuteCommand((TRequest)command);
        }


        protected abstract TResult ExecuteCommand(TRequest command);
    }

    internal interface IHandler
    {
        CommandResult Execute(Command command);
    }
}
