﻿
using System.ComponentModel;

namespace BlazorECommerceApp.Entities
{
    public class Base
    {
        public int Id { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; }= DateTime.Now;

        [DefaultValue(null)]
        public DateTime? UpdatedAt { get; set; } 
    }
}
