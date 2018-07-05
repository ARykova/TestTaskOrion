using System;
using System.Collections.Generic;
using System.Text;

namespace TestTaskOrion.Model
{
    public class ComplexTariff : ITariff
    {
        public int Id { get; set; }
        public Service MainService { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public InternetTariff Internet { get; set; }
        public TVTariff TV { get; set; }
    }
}
