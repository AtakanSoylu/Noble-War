using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NobleWar.PlayerControls
{
    [CreateAssetMenu(menuName = "NobleWar/Player/Movement Setting")]

    public class PlayerMovementSettings : ScriptableObject
    {
        public float PlayerSpeed = 5;
    }
}
