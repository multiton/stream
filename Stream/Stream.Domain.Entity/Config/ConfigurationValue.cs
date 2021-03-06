﻿using System;
using System.ComponentModel.DataAnnotations;

using Stream.Domain.Entity.Facade;

namespace Stream.Domain.Entity.Config
{
    public class ConfigurationValue : BaseEntity<Guid>
    {
        [Required]
        [StringLength(32)]
        public string Section { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(4096)]
        public string Description { get; set; }

        [StringLength(4096)]
        public string DefaultValue { get; set; }

        [StringLength(4096)]
        public string CurrentValue { get; set; }

        public Guid TenantId { get; set; }
    }
}