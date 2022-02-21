using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FollowerSystem : MonoBehaviour
{
    private int numFollowers;

    private void Awake()
    {
        
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        numFollowers = FollowerManager.followers;
    }

    public void FollowerIncrease()
    {
        numFollowers += 1;
        FollowerManager.followers = numFollowers;
    }

    public void FollowerDecrease()
    {
        numFollowers -= 1;
        FollowerManager.followers = numFollowers;
    }
}
