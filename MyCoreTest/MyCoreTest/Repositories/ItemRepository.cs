using System;
using System.Collections.Generic;
using System.Linq;
using Domains.Conversation;
using MyCoreTest.Dal.Contracts;
using MyCoreTest.EF;

namespace MyCoreTest.Repositories
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
            var result = (MyCoreEntityState) (int) conversationContext.Items.Remove(item).State;
            conversationContext.SaveChanges();
            return result;
        }

        public MyCoreEntityState Add(Item item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            using var conversationContext = new ConversationContext();

            var result = (MyCoreEntityState)(int)conversationContext.Items.Add(item).State;
            conversationContext.SaveChanges();
            return result;
        }
    }
}
