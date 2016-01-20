using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using Stream.Domain.Entity.Facade;

namespace Stream.Domain.Entity.Product
{
    public class Category :  Entity<Guid, GuidIdInitializer>
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Guid? ParentId { get; set; }

        public bool Disabled { get; set; }

        public virtual Category Parent { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}