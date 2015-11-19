using System;
using System.Collections.Generic;

namespace Stream.Domain.Entity
{
    public class Category
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        
        public Guid? ParentId { get; set; }

        public virtual Category Parent { get; set; }
        
        public virtual ICollection<Category> Categories { get; set; } 
    }
}