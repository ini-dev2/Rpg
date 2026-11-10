#region USINGS

using System;
using Zenject;
using UnityEngine;
using Rpg.Domain;
using Rpg.Presentations;

#endregion USINGS

namespace Rpg.Arhitecture
{
    internal sealed class InventoryInstaller : MonoInstaller
    {
        [SerializeField] private InventoryView inventoryView;

        public override void InstallBindings()
        {
            Container.Bind<IInventory>()
                .To<Inventory>()
                .AsSingle()
                .NonLazy();

            Container.Bind<InventoryView>()
                .FromInstance(inventoryView)
                .AsSingle()
                .NonLazy();

            Container.Bind<IInventoryPresenter>()
                .To<InventoryPresenter>()
                .AsSingle()
                .NonLazy();

            Container.Bind<Test>()
                .FromNewComponentOnNewGameObject()
                .AsSingle()
                .NonLazy();
        }
    }
}