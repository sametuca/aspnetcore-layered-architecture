using MvcDemo.Core.ResponseRequest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MvcDemo.Core.Facade
{
    public interface IFacadeExecuter
    {
        TResponse ExecuteFunction<TResponse>(Func<TResponse> func)
            where TResponse : BaseResponse;

        Task<TResponse> ExecuteFunctionAsync<TResponse>(Func<Task<TResponse>> func)
            where TResponse : BaseResponse;

        void ExecuteAction(Action action);
    }
}
