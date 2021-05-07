using MediatR;
using MvcDemo.Facade.Interface;
using ResponseRequest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MvcDemo.Facade
{
    public class BlogFacade : IBlogFacade
    {
        private readonly IMediator mediatr;

        public BlogFacade(IMediator mediatr)
        {
            this.mediatr = mediatr;
        }
        public async Task<GetWriterResponse> Get(GetWriterRequest request)
        {
            return await mediatr.Send(request);
        }
    }
}
