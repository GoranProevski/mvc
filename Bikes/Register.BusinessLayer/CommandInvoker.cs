using Register.BusinessLayer.Contracts;
using Register.BusinessLayer.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.BusinessLayer
{
    /// <summary>
    /// Provides method for invoking commands from other layers
    /// </summary>
    public class CommandInvoker
    {
        /// <summary>
        /// entry point for execution of commands
        /// </summary>
        /// <typeparam name="TRequest"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="command"></param>
        /// <returns></returns>
        public static TResult InvokeCommand<TRequest, TResult>(TRequest command) where TRequest : Command
                                                                                 where TResult: CommandResult
        {
            IHandler _handler = GetHandler<TRequest>();
            TResult _result = default(TResult);

            if (_handler != null)
            {
                _result = (TResult)_handler.Execute(command);
            }

            return _result;
        }

        /// <summary>
        /// factory method for creating handlers
        /// </summary>
        /// <typeparam name="TRequest"></typeparam>
        /// <returns></returns>
        private static IHandler GetHandler<TRequest>()
        {
            if (typeof(TRequest) == typeof(BikeSearchCommand))
            {
                return new BikeSearchCommandHandler();
            }

            if (typeof(TRequest) == typeof(BikeDisplayCommand))
            {
                return new BikeDisplayCommandHandler();
            }

            return null;
        }
    }
}
