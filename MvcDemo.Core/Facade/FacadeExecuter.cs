using MvcDemo.Core.ResponseRequest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MvcDemo.Core.Facade
{
    public class FacadeExecuter : IFacadeExecuter
    {
        private readonly ILogger logger;

        public FacadeExecuter(ILogger logger)
        {
            this.logger = logger;
        }
        public void ExecuteAction(Action action)
        {
            throw new NotImplementedException();
        }

        public TResponse ExecuteFunction<TResponse>(Func<TResponse> func) where TResponse : BaseResponse
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> ExecuteFunctionAsync<TResponse>(Func<Task<TResponse>> func) where TResponse : BaseResponse
        {
            throw new NotImplementedException();
        }
    }
}
