#region USINGS

using Rpg.Domain;
using System;
using UnityEngine;

#endregion USINGS

namespace Rpg.Presentations
{
    internal sealed class InventoryPresenter : IInventoryPresenter
    {
        private readonly IInventory _inventory;
        private readonly InventoryView _inventoryView;

        public InventoryPresenter(IInventory inventory, InventoryView inventoryView)
        {
            _inventory = inventory ?? throw new ArgumentNullException(nameof(inventory));
            _inventoryView = inventoryView ?? throw new ArgumentNullException(nameof(inventoryView));

            _inventory.OnRefresh += Refresh;
        }

        private void Refresh()
        {
            _inventoryView.GenerateList(_inventory.Items);
        }
    }
}