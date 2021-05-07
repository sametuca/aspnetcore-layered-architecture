using MvcDemo.Core.Entities;
using MvcDemo.Domain.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace MvcDemo.Domain.Entities
{
    public class Content : BaseEntity, IEntity
    {
        [StringLength(1000)]
        public string Value { get; set; }
        public DateTime Date { get; set; }
        public int HeadingId { get; set; } //1.ForeignKey
        public virtual Heading Heading { get; set; }
        public int? WriterId { get; set; } //2.ForeignKey (int? : bos bırakılabilir yapıyoruz)
        public virtual Writer Writer { get; set; }
    }
}
