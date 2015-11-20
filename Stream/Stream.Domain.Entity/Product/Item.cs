using System;
using System.ComponentModel.DataAnnotations;

namespace Stream.Domain.Entity.Product
{
    public class Item
    {
        public Guid Id { get; set; } // = Guid.NewGuid();

        [Required]
        public string Name { get; set; }
    }
}