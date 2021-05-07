using MvcDemo.Core.Entities;
using MvcDemo.Domain.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcDemo.Domain.Entities
{
    public class Category : BaseEntity,IEntity
    {
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        public bool Status { get; set; }
        public ICollection<Heading> Headings { get; set; }
    }
}
