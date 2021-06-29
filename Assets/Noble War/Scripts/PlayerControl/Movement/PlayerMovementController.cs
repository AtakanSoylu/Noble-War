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
            CharacterMovement();
            CharacterRotation();
        }

        private void CharacterMovement()
        {
            Vector3 move = new Vector3(_inputData.Horizontal, 0, _inputData.Vertical);
            _characterController.Move(_playerMovementSettings.PlayerSpeed * Time.deltaTime * move);
        }

        private void CharacterRotation()
        {
            if (_inputData.Horizontal > 0)
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), _playerMovementSettings.LerpSpeed * Time.deltaTime);
            else if (_inputData.Horizontal < 0)
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), _playerMovementSettings.LerpSpeed * Time.deltaTime);
            if (_inputData.Vertical > 0)
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), _playerMovementSettings.LerpSpeed * Time.deltaTime);
            else if (_inputData.Vertical < 0)
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), _playerMovementSettings.LerpSpeed * Time.deltaTime);
        }



    }
}
