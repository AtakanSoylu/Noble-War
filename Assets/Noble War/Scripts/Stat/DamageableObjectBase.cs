using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NobleWar.Stat
{
    public class DamageableObjectBase : MonoBehaviour, IDamageable
    {
        [SerializeField] private Collider _colidder;
        public int InstanceId { get; private set; }
        public float Health = 100;

        protected virtual void Awake()
        {
            InstanceId = _colidder.GetInstanceID();
            this.InitializeDamageable();
        }

        protected virtual void Destroy()
        {
            this.DestroyDamageable();
        }

        public virtual void Damage(float dmg)
        {
            Health -= dmg;
            Debug.Log("Health: " + Health);
        }


    }
}
