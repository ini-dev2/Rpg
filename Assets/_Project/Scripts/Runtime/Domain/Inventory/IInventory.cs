#region USINGS

using System;
using System.Collections.Generic;

#endregion USINGS

namespace Rpg.Domain
{
    public interface IInventory
    {
        event Action OnRefresh;
        IReadOnlyList<IInventoryItem> Items { get; }
        void Add(IInventoryItem item);
        void Remove(IInventoryItem item);
    }
}