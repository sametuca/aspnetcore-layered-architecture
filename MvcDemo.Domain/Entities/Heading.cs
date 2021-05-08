using MvcDemo.Core.Entities;
using MvcDemo.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcDemo.Domain.Entities
{
    public class Heading : BaseEntity, IEntity
    {
        [StringLength(50)]
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int CategoryId { get; set; } 
        public virtual Category Category { get; set; } 
        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }
        public ICollection<Content> Contents { get; set; } 
    }
}