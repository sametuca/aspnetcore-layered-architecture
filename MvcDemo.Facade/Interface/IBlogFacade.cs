using ResponseRequest;
using System.Threading.Tasks;

namespace MvcDemo.Facade.Interface
{
    public interface IBlogFacade
    {
        Task<GetWriterResponse> Get(GetWriterRequest request);
    }
}
