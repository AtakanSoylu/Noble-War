using NobleWar.PlayerInput;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NobleWar.PlayerControls
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private InputData _inputData;
        [SerializeField] private PlayerMovementSettings _playerMovementSettings;
        [SerializeField] private CharacterController _characterController;
        

        private void Update()
        {

            Vector3 move = new Vector3(_inputData.Horizontal, 0, _inputData.Vertical);
            _characterController.Move(move * Time.deltaTime * _playerMovementSettings.PlayerSpeed);
        }


    }
}
