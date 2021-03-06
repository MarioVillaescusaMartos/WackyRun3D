using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassGenerator : MonoBehaviour
{    
    [SerializeField]
    private Transform[] positions;

    [SerializeField]
    private float waitTime;

    void Start()
    {
        StartCoroutine(GenerateGrass());
    }

    IEnumerator GenerateGrass()
    {
        
        int model = Random.Range(0, 2);
        int otherPoint = Random.Range(0, positions.Length);
        int model2 = Random.Range(0, 2);
        int point = Random.Range(0, positions.Length);

        if (model == 0)
        {
            if (point == 0)
            {
                GameObject grassLeft = PoolingManager.Instance.GetPooledObject("Grass1List");
                grassLeft.transform.position = positions[0].position;
                grassLeft.transform.rotation = positions[0].rotation;
                grassLeft.SetActive(true);

                if (model2 == 0)
                {
                    GameObject grassRight = PoolingManager.Instance.GetPooledObject("Grass1List");
                    grassRight.transform.position = positions[1].position;
                    grassRight.transform.rotation = positions[1].rotation;
                    grassRight.SetActive(true);
                }
                else
                {
                    GameObject grassRight = PoolingManager.Instance.GetPooledObject("Grass2List");
                    grassRight.transform.position = positions[1].position;
                    grassRight.transform.rotation = positions[1].rotation;
                    grassRight.SetActive(true);
                }
            }
            else
            {
                GameObject grassRight = PoolingManager.Instance.GetPooledObject("Grass1List");
                grassRight.transform.position = positions[1].position;
                grassRight.transform.rotation = positions[1].rotation;
                grassRight.SetActive(true);

                if (model2 == 0)
                {
                    GameObject grassLeft = PoolingManager.Instance.GetPooledObject("Grass1List");
                    grassLeft.transform.position = positions[0].position;
                    grassLeft.transform.rotation = positions[0].rotation;
                    grassLeft.SetActive(true);
                }
                else
                {
                    GameObject grassLeft = PoolingManager.Instance.GetPooledObject("Grass2List");
                    grassLeft.transform.position = positions[0].position;
                    grassLeft.transform.rotation = positions[0].rotation;
                    grassLeft.SetActive(true);
                }
            }
        }
        else
        {
            if (point == 0)
            {
                GameObject grassLeft = PoolingManager.Instance.GetPooledObject("Grass2List");
                grassLeft.transform.position = positions[0].position;
                grassLeft.transform.rotation = positions[0].rotation;
                grassLeft.SetActive(true);

                if (model2 == 0)
                {
                    GameObject grassRight = PoolingManager.Instance.GetPooledObject("Grass1List");
                    grassRight.transform.position = positions[1].position;
                    grassRight.transform.rotation = positions[1].rotation;
                    grassRight.SetActive(true);
                }
                else
                {
                    GameObject grassRight = PoolingManager.Instance.GetPooledObject("Grass2List");
                    grassRight.transform.position = positions[1].position;
                    grassRight.transform.rotation = positions[1].rotation;
                    grassRight.SetActive(true);
                }
            }
            else
            {
                GameObject grassRight = PoolingManager.Instance.GetPooledObject("Grass2List");
                grassRight.transform.position = positions[1].position;
                grassRight.transform.rotation = positions[1].rotation;
                grassRight.SetActive(true);

                if (model2 == 0)
                {
                    GameObject grassLeft = PoolingManager.Instance.GetPooledObject("Grass1List");
                    grassLeft.transform.position = positions[0].position;
                    grassLeft.transform.rotation = positions[0].rotation;
                    grassLeft.SetActive(true);
                }
                else
                {
                    GameObject grassLeft = PoolingManager.Instance.GetPooledObject("Grass2List");
                    grassLeft.transform.position = positions[0].position;
                    grassLeft.transform.rotation = positions[0].rotation;
                    grassLeft.SetActive(true);
                }
            } 
        }       

        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GenerateGrass());
    }
}
