using System.ComponentModel.DataAnnotations;

namespace MvcDemo.Domain.Entities.Base
{
    public class IdEntity<T>
    {
        [Key]
        public T Id { get; set; }
    }

    public class IdEntity : IdEntity<int>
    {
    }
}
