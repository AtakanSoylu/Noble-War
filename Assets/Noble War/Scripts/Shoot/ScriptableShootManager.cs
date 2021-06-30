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
    }
}