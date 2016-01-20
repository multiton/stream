using System;
using System.ComponentModel.DataAnnotations;
using Stream.Domain.Entity.Facade;

namespace Stream.Domain.Entity.Product
{
    public class Item : Entity<Guid, GuidIdInitializer>
    {
        [Required]
        public string Name { get; set; }
    }
}