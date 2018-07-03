using System.ComponentModel.DataAnnotations;

namespace TestTaskOrion.Model
{
    public class Appeal
    {
        public enum AppealReason { FirstConnection, Failure, ChangeTerms, Payment, Other }

        [Required]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string City { get; set; }

        [Required, MaxLength(50)]
        public string Surname { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Patronymic { get; set; }

        [Required, MaxLength(500)]
        public string Address { get; set; }

        [Required]
        public AppealReason Reason { get; set; }

        [MaxLength(500)]
        public string Comment { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }        
    }
}
