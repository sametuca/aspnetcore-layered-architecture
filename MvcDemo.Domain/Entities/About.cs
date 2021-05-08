using MvcDemo.Core.Entities;
using MvcDemo.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcDemo.Domain.Entities
{
    public class About : BaseEntity,IEntity
    {
        [StringLength(500)]
        public string Details1 { get; set; }
        [StringLength(1000)]
        public string Details2 { get; set; }
        [StringLength(100)]
        public string Image1 { get; set; }
        [StringLength(100)]
        public string Image2 { get; set; }
    }
}
