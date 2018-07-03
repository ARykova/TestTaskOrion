using System;
using System.Collections.Generic;
using System.Text;

namespace TestTaskOrion.Model
{
    public class Service : IOfferable
    {
        public string Title { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }
    }
}
