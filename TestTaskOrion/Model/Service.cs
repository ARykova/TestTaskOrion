﻿namespace TestTaskOrion.Model
{
    public class Service : IOfferable
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }
       
    }
}
