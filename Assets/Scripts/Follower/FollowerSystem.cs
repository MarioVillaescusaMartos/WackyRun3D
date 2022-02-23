using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerSystem : MonoBehaviour
{
    private int numFollowers;

    [SerializeField]
    private int followerIncrement;

    private FollowerHealthSystem _follHealth;
    private FollowerMovement _follMov;

    private void Awake()
    {
        _follHealth = GetComponent<FollowerHealthSystem>();
        _follMov = GetComponent<FollowerMovement>();
    }

    private void OnEnable()
    {
        _follHealth.OnHealthZero += FollowerDecrease;
        _follMov.OnStartFollow += FollowerIncrease;
    }

    private void OnDisable()
    {
        _follHealth.OnHealthZero -= FollowerDecrease;
        _follMov.OnStartFollow -= FollowerIncrease;
    }
    // Start is called before the first frame update
    void Start()
    {
        numFollowers = FollowerManager.followers;
    }

    public void FollowerIncrease()
    {
        numFollowers = FollowerManager.followers + followerIncrement;

        FollowerManager.followers = numFollowers;
    }

    public void FollowerDecrease()
    {
        numFollowers = FollowerManager.followers - followerIncrement;

        FollowerManager.followers = numFollowers;
    }
}
