using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesGenerator : MonoBehaviour
{
    [SerializeField]
    private Transform[] positions;

    private int obstacleSelection;

    private int obstaclePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        obstacleSelection = Random.Range(0, 7);

        if (obstacleSelection == 0)//Hammer smash right
        {
            GameObject grassLeft = PoolingManager.Instance.GetPooledObject("HammerLeftList");
            grassLeft.transform.position = positions[3].position;
            grassLeft.SetActive(true);
        }
        else if (obstacleSelection == 1)//Hammer smash left
        {
            GameObject grassLeft = PoolingManager.Instance.GetPooledObject("HammerRightList");
            grassLeft.transform.position = positions[4].position;
            grassLeft.SetActive(true);
        }
        else if (obstacleSelection == 2)//Fox run left
        {
            GameObject grassLeft = PoolingManager.Instance.GetPooledObject("FoxLeftList");
            grassLeft.transform.position = positions[6].position;
            grassLeft.SetActive(true);
        }
        else if (obstacleSelection == 3)//Fox run right
        {
            GameObject grassLeft = PoolingManager.Instance.GetPooledObject("FoxRightList");
            grassLeft.transform.position = positions[5].position;
            grassLeft.SetActive(true);
        }
        else if(obstacleSelection == 4)//Barrier
        {
            obstaclePosition = Random.Range(0, 3);

            GameObject grassLeft = PoolingManager.Instance.GetPooledObject("BarrierList");
            grassLeft.transform.position = positions[obstaclePosition].position;
            grassLeft.SetActive(true);
        }
        else if (obstacleSelection == 5)//Spider
        {
            obstaclePosition = Random.Range(0, 3);

            GameObject grassLeft = PoolingManager.Instance.GetPooledObject("SpiderList");
            grassLeft.transform.position = positions[obstaclePosition].position;
            grassLeft.SetActive(true);
        }
        else if (obstacleSelection == 6)//Tunnel
        {
            GameObject grassLeft = PoolingManager.Instance.GetPooledObject("TunnelList");
            grassLeft.transform.position = positions[1].position;
            grassLeft.SetActive(true);
        }
    }
}
