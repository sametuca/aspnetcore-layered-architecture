using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MvcDemo.Core.Repository
{
    public interface IRepository<TCreateDTO,TUpdateDTO,TItemDTO>
    {
        public Task<int> Create(TCreateDTO entity);
        public Task<bool> Delete(int id);
        public Task<bool> Update(TUpdateDTO entity);
        public Task<TCreateDTO> Get(int id);
        public Task<TItemDTO> GetAlll();
    }
}
