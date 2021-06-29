using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NobleWar.Inventory
{
    public class PlayerInventoryController : MonoBehaviour
    {

        [SerializeField] private AbstractBasePlayerInventoryItemData[] _inventoryItemDataArray;

        public Transform Parent;



        public void InitializeInventory(AbstractBasePlayerInventoryItemData[] inventoryItemDataArray)
        {
            for (int i = 0; i < inventoryItemDataArray.Length; i++)
            {
                inventoryItemDataArray[i].CreateIntoInventory(this);
            }
        }
    }
}
