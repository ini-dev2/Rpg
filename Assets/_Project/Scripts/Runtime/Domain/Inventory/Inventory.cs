#region USINGS

using System;
using System.Collections.Generic;

#endregion USINGS

namespace Rpg.Domain
{
    internal sealed class Inventory : IInventory
    {
        private readonly List<IInventoryItem> _items = new();

        public IReadOnlyList<IInventoryItem> Items => _items;

        public event Action OnRefresh;

        public Inventory()
        {
        }

        public Inventory(List<IInventoryItem> items)
        {
            _items = items ?? throw new ArgumentNullException(nameof(items));
        }

        public void Add(IInventoryItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (_items.Contains(item))
            {
                throw new ArgumentNullException(nameof(item));
            }

            _items.Add(item);

            OnRefresh?.Invoke();
        }

        public void Remove(IInventoryItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (!_items.Contains(item))
            {
                throw new ArgumentNullException(nameof(item));
            }

            _items.Remove(item);

            OnRefresh?.Invoke();
        }
    }
}