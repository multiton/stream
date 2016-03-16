using System;
using System.ComponentModel.DataAnnotations;

using Stream.Domain.Entity.Facade;

namespace Stream.Domain.Entity.Config
{
    public class Tenant : BaseEntity<Guid>
    {
        [Required]
        [StringLength(32)]
        public string Name { get; set; }

        public bool Discontinued { get; set; }
    }
}