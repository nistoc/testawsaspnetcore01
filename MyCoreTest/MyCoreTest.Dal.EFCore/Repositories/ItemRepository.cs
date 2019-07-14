using Domains.Conversation;
using MyCoreTest.Dal.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCoreTest.Dal.EFCore.Repositories
{
    public class ItemRepository : IItemRepository
    {
        public List<Item> All()
        {
            using var conversationContext = new ConversationContext();
            var result = conversationContext.Items.ToList();
            return result;
        }

        public MyCoreEntityState Remove(Item item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            using var conversationContext = new ConversationContext();

            return (MyCoreEntityState)(int)conversationContext.Items.Remove(item).State;
        }

        public MyCoreEntityState Add(Item item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            using var conversationContext = new ConversationContext();

            return (MyCoreEntityState)(int)conversationContext.Items.Add(item).State;
        }
    }
}
