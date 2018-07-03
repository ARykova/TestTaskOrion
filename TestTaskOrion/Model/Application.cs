using System;
using System.Collections.Generic;
using System.Text;

namespace TestTaskOrion.Model
{
    public class Application
    {
        public int Id { get; set; }
        public Appeal Appeal { get; set; }
        public IOfferable Offer { get; set; }
    }
}
