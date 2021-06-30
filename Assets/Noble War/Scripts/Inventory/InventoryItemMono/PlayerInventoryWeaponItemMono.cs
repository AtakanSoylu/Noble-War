using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NobleWar.Shoot;

namespace NobleWar.Inventory
{
    public class PlayerInventoryWeaponItemMono : AbstractPlayerInventoryItemMono
    {
        [SerializeField] private Transform _shootPoint;
        public void Shoot()
        {
            ScriptableShootManager.Instance.Shoot(_shootPoint.position, _shootPoint.position);
        }
    }
}