using System;
using System.Collections.Generic;
using System.Linq;
using Domains.Conversation;

namespace MyCoreTest.Dal.Contracts
{
    public interface IItemRepository
    {
        List<Item> All();
        MyCoreEntityState Remove(Item item);
        MyCoreEntityState Add(Item item);
    }
}
