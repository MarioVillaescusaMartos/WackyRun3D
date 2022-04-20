using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFollowerSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void  DeleteFollowers()
    {
        for (int i = 0;  i < FollowerManager.followers; i++)
        {
            GameObject follower = PoolingManager.Instance.GetActiveObject("FollowersList");

            if (follower.GetComponent<FollowerMovement>().ReturnTouched())
            {
                follower.SetActive(false);

                FollowerManager.followers = FollowerManager.followers - 1;
            }
        }

        //gameObject.SetActive(false);
    }
}
