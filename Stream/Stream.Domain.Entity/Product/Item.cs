using System;
using System.ComponentModel.DataAnnotations;
using Stream.Domain.Entity.Facade;

namespace Stream.Domain.Entity.Product
{
    public class Item : BaseEntity<Guid>
    {
        [Required]
        public string Name { get; set; }
    }
}