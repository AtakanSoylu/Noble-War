using NobleWar.Inventory;
using NobleWar.PlayerControls;
using NobleWar.PlayerInput;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NobleWar.AI
{
    public class AIController : MonoBehaviour
    {
        [SerializeField] private InputDataAI _aiMovementInput;
        [SerializeField] private PlayerMovementController _playerMovementController;
        [SerializeField] private PlayerInventoryController _inventoryController;

        private void Awake()
        {
            _aiMovementInput = Instantiate(_aiMovementInput);

            _playerMovementController.InitializeInput(_aiMovementInput);
        }


        private void Update()
        {
            _aiMovementInput.ProcessInput();
        }

    }
}
