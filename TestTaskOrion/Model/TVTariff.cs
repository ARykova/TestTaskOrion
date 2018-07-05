using System;
using System.Collections.Generic;
using System.Text;

namespace TestTaskOrion.Model
{
    public class TVTariff : ITariff
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Service MainService { get; set; }
        public double Price { get; set; }
        public double ChannelsCount { get; set; }
        public List<string> ChannelsList { get; set; }
        public string Description { get; set; }
    }
}
