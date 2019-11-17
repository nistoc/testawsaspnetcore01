using System;

namespace Domains.Conversation
{
    public class Item
    {
        public int ItemId { get; set; }

        public string Message { get; set; }

        public int? SourceId { get; set; }
        public virtual Source Source { get; set; }

        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
    }
}
