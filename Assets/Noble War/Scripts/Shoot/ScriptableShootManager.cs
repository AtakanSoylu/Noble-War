using System.Collections;
using System.Collections.Generic;
using NobleWar.Inventory;
using UnityEngine;

namespace NobleWar.Shoot
{
    [CreateAssetMenu(menuName = "NobleWar/Shoot/ScriptableShootManager")]

    public class ScriptableShootManager : AbstractScriptableManager<ScriptableShootManager>
    {
        public override void Initialize()
        {
            base.Initialize();
            Debug.Log("Scriptable shoot manager activated");
        }
        public override void Destroy()
        {
            base.Destroy();
            Debug.Log("Scriptable shoot manager destroyed");

        }

        public void Shoot(Vector3 origin, Vector3 direction)
        {
            RaycastHit rHit;
            var physic = Physics.Raycast(origin, direction, out rHit);
            if (physic)
            {
                Debug.Log("Collier : " + rHit.collider.name);
            }
        }
    }
}