using System;
using System.Collections.Generic;

namespace Domains.Conversation
{
    public class Source
    {

        public int SourceId { get; set; }
        public string Name { get; set; }

        public virtual List<Item> Items { get; set; }


        public bool Rmv { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime CreatedBy { get; set; }
    }
}