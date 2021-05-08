using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MvcDemo.UI.Controllers
{
    public class BaseGenericController<TController,TFacade,TUpdateDTO,TCreateDTO,TItemDTO> : ControllerBase
    {
        private readonly TFacade facade;

        public BaseGenericController(TFacade facade)
        {
            this.facade = facade;
        }

    }
}
