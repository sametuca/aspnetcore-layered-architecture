using System;
using System.ComponentModel.DataAnnotations;

namespace MvcDemo.Domain.Entities.Base
{
    public class BaseEntity<T> : IdEntity<T>
    {
        public DateTime CreatedDate { get; set; }
    }

    public class BaseEntity : BaseEntity<int>
    {
    }
}
