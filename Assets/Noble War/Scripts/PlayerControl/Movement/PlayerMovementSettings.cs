using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NobleWar.PlayerControls
{
    [CreateAssetMenu(menuName = "NobleWar/Player/Movement Setting")]

    public class PlayerMovementSettings : ScriptableObject
    {
        [SerializeField] private float _playerSpeed = 5;
        public float PlayerSpeed { get { return _playerSpeed; } }

        [SerializeField] private float _lerpSpeed = 5;
        public float LerpSpeed { get { return _lerpSpeed; } }

        public float CurrentSpeed;

    }
}
