using System;
using System.Collections.Generic;
using System.Text;

namespace TestTaskOrion.Model
{
    public class InternetTariff : ITariff
    {
        public int Id { get; set; }
        public Service MainService { get; set; }
        public string Title { get; set; }
        public double Price { get; set ; }
        public double NightSpeed { get; set; }
        public double DaySpeed { get; set; }
        public string Description { get; set; }
    }
}
