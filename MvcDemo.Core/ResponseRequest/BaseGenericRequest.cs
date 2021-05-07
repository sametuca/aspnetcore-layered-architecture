using MediatR;

namespace MvcDemo.Core.ResponseRequest
{
    public class BaseGenericRequest<TModel> : BaseRequest,IRequest<TModel>
    {

    }
}
