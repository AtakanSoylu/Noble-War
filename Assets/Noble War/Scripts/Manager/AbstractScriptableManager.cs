using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NobleWar
{
    public abstract class AbstractScriptableManager<T> : AbstractScriptableManagerBase where T:AbstractScriptableManager<T>
    {
        public static T Instance;

        public override void Initialize()
        {
            base.Initialize();
            Instance = this as T;

        }

        public override void Destroy()
        {
            base.Destroy();
        }



    }
}