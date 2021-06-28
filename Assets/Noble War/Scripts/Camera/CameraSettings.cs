using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace NobleWar.Camera
{
    [CreateAssetMenu(menuName = "NobleWar/Camera/Camera Settings")]
    public class CameraSettings : ScriptableObject
    {
        [SerializeField] private float _rotationLerpSpeed = 1;
        public float RotationLerpSpeed { get { return _rotationLerpSpeed; } }

        [SerializeField] private Vector3 _positionOffset;
        public Vector3 PositionOffset { get { return _positionOffset; } }

        [SerializeField] private float _positionLerp = 1;
        public float PositionLerp { get { return _positionLerp; } }
    }
}
