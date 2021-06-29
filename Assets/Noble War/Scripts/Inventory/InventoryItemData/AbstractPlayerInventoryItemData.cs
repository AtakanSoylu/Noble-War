using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace NobleWar.Inventory
{
    public enum InventoryItemDataType { Weapon, Armor, Shoes}
    public abstract class AbstractPlayerInventoryItemData<T> : AbstractBasePlayerInventoryItemData 
        where T: AbstractPlayerInventoryItemMono
    {
        [SerializeField] protected string _itemId;
        [SerializeField] protected InventoryItemDataType _inventoryItemDataType;
        [SerializeField] protected T _prefab;

        protected T InstantiateAndInitializePrefab(Transform parent)
        {
            return Instantiate(_prefab, parent);
        }
    }
}