#region USINGS

using System.Collections.Generic;

#endregion USINGS

namespace Rpg.Domain
{
    public interface IInventory
    {
        IReadOnlyList<IInventoryItem> Items { get; }
        void Add(IInventoryItem item);
        void Remove(IInventoryItem item);
    }
}