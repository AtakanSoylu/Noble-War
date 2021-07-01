using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace NobleWar.AI
{
    [CreateAssetMenu(menuName = "NobleWar/Input/AI Movement Data")]
    public class InputMovementDataAI : InputDataAI
    {
        public override void ProcessInput()
        {
            float distance = Vector3.Distance(_aiTransform.position, _currentTarget);
            if (distance > 0)
            {
                Horizontal = 1;
            }
            else
            {
                Horizontal = 0;
            }
        }
    }
}