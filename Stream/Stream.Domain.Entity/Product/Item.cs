using System;
using System.ComponentModel.DataAnnotations;
using Stream.Domain.Entity.Facade;

namespace Stream.Domain.Entity.Product
{
    public class Item : BaseEntity<Guid>
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}