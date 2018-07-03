using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TestTaskOrion.Model
{
    public interface IOfferable
    {
        [Required, MaxLength(50)]
        string Title { get; set; }
        
        [Required]
        double Price { get; set; }

        [MaxLength(5000)]
        string Description { get; set; }
    }
}
