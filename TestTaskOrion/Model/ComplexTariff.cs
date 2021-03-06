﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestTaskOrion.Model
{
    public class ComplexTariff : ITariff
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}
