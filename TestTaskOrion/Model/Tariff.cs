using System.ComponentModel.DataAnnotations;

namespace TestTaskOrion.Model
{
    public class Tariff : IOfferable
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public double Price { get; set; }

        [Required, Range(0, 1000)]
        public double DaySpeed { get; set; }

        [Required, Range(0, 1000)]
        public double NightSpeed { get; set; }

        public string Description { get; set; }
    }
}
