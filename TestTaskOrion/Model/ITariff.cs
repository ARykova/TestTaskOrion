using System.ComponentModel.DataAnnotations;

namespace TestTaskOrion.Model
{
    public interface ITariff 
    {
        int Id { get; set; }
        
        string Title { get; set; }

        double Price { get; set; }        

        string Description { get; set; }
    }
}
