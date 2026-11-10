#region USINGS

using System;
using System.Collections.Generic;

#endregion USINGS

namespace Rpg.Domain
{
    internal sealed class Inventory : IInventory
    {
        private readonly List<IInventoryItem> _items = new();

        public Inventory()
        {
        }

        public Inventory(List<IInventoryItem> items)
        {
            _items = items ?? throw new ArgumentNullException(nameof(items));
        }

        public IReadOnlyList<IInventoryItem> Items => _items;

        public void Add(IInventoryItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            _items.Add(item);
        }

        public void Remove(IInventoryItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            _items.Remove(item);
        }
    }
}