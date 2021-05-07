using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDemo.UI.Controllers
{
    public class BaseGenericController<TController,TFacade,TUpdateDTO,TCreateDTO,TItemDTO> : BaseController
    {
        private readonly TFacade facade;

        public BaseGenericController(TFacade facade)
        {
            this.facade = facade;
        }
        [HttpGet]
        public async Task<IActionResult> GetItem(int id)
        {
            var item = await facade.GetITem();
            return Ok(item);
        }
    }
}
