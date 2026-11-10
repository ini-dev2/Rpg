using Rpg.Domain;
using Rpg.Presentations;
using Sirenix.OdinInspector;
using System;
using UnityEngine;
using Zenject;

public class Test : MonoBehaviour
{
    private IInventory inventory;
    private IInventoryPresenter inventoryPresenter;

    [Inject]
    public void Init(IInventory inventory, IInventoryPresenter inventoryPresenter)
    {
        this.inventory = inventory ?? throw new ArgumentNullException(nameof(inventory));
        this.inventoryPresenter = inventoryPresenter ?? throw new ArgumentNullException(nameof(inventoryPresenter));
    }

    [Button]
    public void Add()
    {
        inventory.Add(new Item());
    }

    [Button]
    public void Remove()
    {
    }

    class Item : IInventoryItem
    {
        public string Name => "Xyi";
    }
}
