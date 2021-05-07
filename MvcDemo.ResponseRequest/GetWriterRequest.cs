
using MvcDemo.Core.ResponseRequest;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseRequest
{
    public class GetWriterRequest : BaseGenericRequest<GetWriterResponse>
    {
        public int Id { get; set; }
    }
}
