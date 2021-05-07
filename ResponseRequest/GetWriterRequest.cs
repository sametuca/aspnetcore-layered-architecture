using MvcDemo.Core.ResponseRequest;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseRequest
{
    public class GetWriterRequest : BaseRequest
    {
        public int Id { get; set; }
    }
}
