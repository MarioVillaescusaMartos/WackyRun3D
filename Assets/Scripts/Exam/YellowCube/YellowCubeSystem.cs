using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCubeSystem : MonoBehaviour
{
    [SerializeField]
    private int numFollowers;

    // Start is called before the first frame update
    void Start()
    {
        
    }    

    public void SpawnFollowers()
    {
        for (int i = 0; i < numFollowers; i++)
        {
            GameObject follower = PoolingManager.Instance.GetPooledObject("FollowersList");
            follower.transform.position = new Vector3(transform.position.x, 0, transform.position.z);
            follower.SetActive(true);
        }

        gameObject.SetActive(false);
    }
}
