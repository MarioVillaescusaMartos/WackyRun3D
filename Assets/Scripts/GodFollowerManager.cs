using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GodFollowerManager : MonoBehaviour
{
    [SerializeField]
    private Transform[] positions;

    private InputSystemKeyboard _inputSystem;

    private void Awake()
    {
        _inputSystem = GetComponent<InputSystemKeyboard>();
    }

    private void OnEnable()
    {
        _inputSystem.OnCreateFollower += CreateFollower;
        _inputSystem.OnDeleteFollower += DeleteFollower;
    }

    private void OnDisable()
    {
        _inputSystem.OnCreateFollower -= CreateFollower;
        _inputSystem.OnDeleteFollower -= DeleteFollower;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void CreateFollower()
    {
        GameObject follower = PoolingManager.Instance.GetPooledObject("FollowersList");
        follower.transform.position = positions[0].position;
        follower.SetActive(true);
    }

    private void DeleteFollower()
    {
        GameObject follower = PoolingManager.Instance.GetActiveObject("FollowersList");
        
        if (follower.GetComponent<FollowerMovement>().ReturnTouched())
        {
            follower.SetActive(false);

            FollowerManager.followers = FollowerManager.followers - 1;
        }
        else
        {
            Debug.Log("null");
        }
    }
}
