using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DieSystem : MonoBehaviour
{
    [SerializeField]
    private float sizeRest;
    [SerializeField]
    private float rotateSpeed;

    private bool die;

    private void Awake()
    {
        die = false;
    }

    private void OnEnable()
    {
        GetComponent<FollowerHealthSystem>().OnHealthZero += Die;
    }

    private void OnDisable()
    {
        GetComponent<FollowerHealthSystem>().OnHealthZero -= Die;
    }

    public void Update()
    {
        if (transform.localScale.x >= 1 && die)
        {
            transform.localScale -= new Vector3(sizeRest * Time.deltaTime, sizeRest * Time.deltaTime, sizeRest * Time.deltaTime);

            transform.Rotate(new Vector3(0, rotateSpeed, 0), Space.World);
        }

        if (transform.localScale.x <= 1)
        {
            gameObject.SetActive(false);
        }
    }

    private void Die()
    {
        die = true;
        Destroy(gameObject.GetComponent<FollowerMovement>());
    }
}
