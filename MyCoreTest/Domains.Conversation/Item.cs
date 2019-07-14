using System;

namespace Domains.Conversation
{
    public class Item
    {
        public int ItemId { get; set; }

        public string Message { get; set; }

        public int SourceId { get; set; }
        public Source Source { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime CreatedBy { get; set; }
    }
}
