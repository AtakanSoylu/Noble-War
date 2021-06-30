using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

namespace NobleWar.Inventory
{
    [CreateAssetMenu(menuName = "NobleWar/Inventory/Player Inventory Weapon Item Data")]

    public class PlayerInventoryWeaponItemData : AbstractPlayerInventoryItemData<PlayerInventoryWeaponItemMono>
    {
        [SerializeField] private float _damage;
        public float Damage { get { return _damage; } }

        [SerializeField] private float _rpm = 1f;
        public float Rpm { get { return _rpm; } }
        private float _lastShootTime;






        public override void Initialize(PlayerInventoryController targetPlayerInventory)
        {
            base.Initialize(targetPlayerInventory);
            InstantiateAndInitializePrefab(targetPlayerInventory.Parent);
            targetPlayerInventory.ReactiveShootCommand.Subscribe(OnReactiveShootCommand).AddTo(_compositeDisposable);

        }

        public override void Destroy()
        {
            base.Destroy();
        }


        private void OnReactiveShootCommand(Unit obj)
        {
            Debug.Log("reactive command shoot");
            Shoot();
        }

        public void Shoot()
        {
            if (Time.time - _lastShootTime > _rpm)
            {
                _instantiated.Shoot();
                _lastShootTime = Time.time;
            }
            else
            {
                Debug.Log("you cant shoot now");
            }
        }




    }
}