using System.Collections.Generic;

namespace TestTaskOrion.Model
{
    public class Service
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public List<ITariff> Tariffs { get; set; }
       
    }
}
