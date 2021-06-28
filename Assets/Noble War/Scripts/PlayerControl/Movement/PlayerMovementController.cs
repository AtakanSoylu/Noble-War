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
        [SerializeField] private Animator _playerAnimator;


        private void Update()
        {
            CharacterMovement();
            CharacterRotation();
            UpdateAnimator();
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
        public void UpdateAnimator()
        {
            if (_inputData.Horizontal != 0 || _inputData.Vertical != 0)
            {
                _playerMovementSettings.CurrentSpeed = Mathf.Lerp(_playerMovementSettings.CurrentSpeed, 1, _playerMovementSettings.PlayerSpeed * Time.deltaTime);
                _playerAnimator.SetFloat("forwardSpeed", _playerMovementSettings.CurrentSpeed);
            }
            else
            {
                _playerMovementSettings.CurrentSpeed = Mathf.Lerp(_playerMovementSettings.CurrentSpeed, 0, _playerMovementSettings.PlayerSpeed * Time.deltaTime);
                _playerAnimator.SetFloat("forwardSpeed", _playerMovementSettings.CurrentSpeed);
            }
        }


    }
}
