using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDamageSystem : DamageSystem
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

        gameObject.SetActive(false);
    }
}
