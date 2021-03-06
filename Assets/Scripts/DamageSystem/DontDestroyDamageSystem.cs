using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyDamageSystem : DamageSystem
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public override void OnTriggerEnter(Collider collision)
    {
        if (collision.TryGetComponent(out HealthSystem damageHealth))
        {
            damageHealth.RestHealth(restHealth);
        }
    }
}
