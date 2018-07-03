using System.ComponentModel.DataAnnotations;

namespace TestTaskOrion.Model
{
    public interface IOfferable
    {
        [Required]
        int Id { get; set; }

        [Required, MaxLength(50)]
        string Title { get; set; }
        
        [Required]
        double Price { get; set; }

        [MaxLength(5000)]
        string Description { get; set; }
    }
}
