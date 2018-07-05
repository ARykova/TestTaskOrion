using System.ComponentModel.DataAnnotations;

namespace TestTaskOrion.Model
{
    public class Appeal
    {
        public enum AppealReason { FirstConnection = 1, Failure = 2, ChangeTerms = 3, Payment = 4, Other = 5 }
        
        public int Id { get; set; }
        
        public string City { get; set; }
        
        public string Surname { get; set; }
        
        public string Name { get; set; }
        
        public string Patronymic { get; set; }
        
        public string Address { get; set; }
        
        public AppealReason Reason { get; set; }
        
        public string Comment { get; set; }
        
        public string PhoneNumber { get; set; }        
    }
}
