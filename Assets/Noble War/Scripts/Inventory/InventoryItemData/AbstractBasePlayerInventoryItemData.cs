using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NobleWar.Inventory
{
    public abstract class AbstractBasePlayerInventoryItemData : ScriptableObject
    {
        public abstract void CreateIntoInventory(PlayerInventoryController targetPlayerInventory);

    }
}