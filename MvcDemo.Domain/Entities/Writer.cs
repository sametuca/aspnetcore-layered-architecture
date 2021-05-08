using MvcDemo.Core.Entities;
using MvcDemo.Domain.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcDemo.Domain.Entities
{
    public class Writer : BaseEntity, IEntity
    {
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string SurName { get; set; }
        [StringLength(100)]
        public string Image { get; set; }
        [StringLength(50)]
        public string Mail { get; set; }
        [StringLength(20)]
        public string Password { get; set; }
        public ICollection<Heading> Headings { get; set; }
        public ICollection<Content> Contents { get; set; }
    }
}