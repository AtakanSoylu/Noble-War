using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NobleWar.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private CameraSettings _cameraSettings;
        [SerializeField] private Transform _targetTranform;
        [SerializeField] private Transform _cameraTranform;


        private void Update()
        {
            CameraRotationFollow();
            CameraMovementFollow();
        }


        private void CameraRotationFollow()
        {
            Vector3 direction = _targetTranform.position - _cameraTranform.position;
            Quaternion toRotation = Quaternion.FromToRotation(_cameraTranform.forward, direction);

            _cameraTranform.rotation = Quaternion.Lerp(_cameraTranform.rotation,
                toRotation,
                Time.deltaTime * _cameraSettings.RotationLerpSpeed);
        }

        private void CameraMovementFollow()
        {
            _cameraTranform.localPosition = Vector3.Lerp(_cameraTranform.localPosition, _targetTranform.localPosition +_cameraSettings.PositionOffset, Time.deltaTime * _cameraSettings.RotationLerpSpeed);
        }
    }
}