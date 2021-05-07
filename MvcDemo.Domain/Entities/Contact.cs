using MvcDemo.Core.Entities;
using MvcDemo.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace MvcDemo.Domain.Entities
{
    public class Contact : BaseEntity, IEntity
    {
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string UserMail { get; set; }
        [StringLength(50)]
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
