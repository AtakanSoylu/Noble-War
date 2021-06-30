using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NobleWar.Stat
{
    public class DamageableObjectBase : MonoBehaviour, IDamageable
    {
        [SerializeField] private Collider _colidder;
        public int InstanceId { get; private set; }

        protected virtual void Awake()
        {
            InstanceId = _colidder.GetInstanceID();
            this.InitializeDamageable();
        }

        public virtual void Damage(float dmg)
        {
            Debug.Log("you damage me : " + dmg);
        }


    }
}
