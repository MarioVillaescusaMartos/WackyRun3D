using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtParticleSystemController : MonoBehaviour
{
    private ParticleSystem _ps;

    private void Awake()
    {
        _ps = GetComponent<ParticleSystem>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FollowerParticleSystemController.dirt)
        {
            _ps.Play(true);
        }
        else
        {
            _ps.Stop(true);
        }
    }
}
