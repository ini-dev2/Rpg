#region USINGS

using Rpg.Domain;
using System;
using System.Collections.Generic;
using UnityEngine;

#endregion USINGS

namespace Rpg.Presentations
{
    internal sealed class InventoryView : MonoBehaviour
    {
        [SerializeField] private Transform contentRoot;
        [SerializeField] private InventoryItemView itemView;

        private List<InventoryItemView> views = new();

        public void Open()
        {

        }

        public void Close()
        {

        }

        public void GenerateList(IReadOnlyList<IInventoryItem> items)
        {
            foreach (var item in views)
            {
                Destroy(item.gameObject);
            }

            views.Clear();

            foreach (var item in items)
            {
                var inst = Instantiate(itemView, contentRoot);
                inst.inventoryItem = item;

                views.Add(inst);
            }
        }

        private void RemoveItem()
        {

        }
    }
}