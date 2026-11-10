#region USINGS

using System;
using System.Collections.Generic;

#endregion USINGS

namespace Rpg.Domain
{
    public interface IInventoryItem
    {
        string Name { get; }
    }

    public interface IInventory
    {
        IReadOnlyList<IInventoryItem> Items { get; }
        void Add(IInventoryItem item);
        void Remove(IInventoryItem item);
    }

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