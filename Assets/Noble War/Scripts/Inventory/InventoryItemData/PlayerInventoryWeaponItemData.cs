using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NobleWar.Inventory
{
    [CreateAssetMenu(menuName = "NobleWar/Inventory/Player Inventory Weapon Item Data")]

    public class PlayerInventoryWeaponItemData : AbstractPlayerInventoryItemData<PlayerInventoryWeaponItemMono>
    {
        [SerializeField] private float _damage;
        public float Damage { get { return _damage; } }

        public override void CreateIntoInventory(PlayerInventoryController targetPlayerInventory)
        {
            var instantiated = InstantiateAndInitializePrefab(targetPlayerInventory.Parent);
        }
    }
}