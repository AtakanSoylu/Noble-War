using NobleWar.Inventory;
using NobleWar.PlayerInput;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NobleWar
{
    public class LocalPlayerController : MonoBehaviour
    {
        [SerializeField] private PlayerInventoryController _inventoryController;
        [SerializeField] private InputData _shootInput;

        private void Update()
        {
            if(_shootInput.Horizontal > 0)
            {
                _inventoryController.ReactiveShootCommand.Execute();
            }
        }

    }
}
