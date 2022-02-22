using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxGenerator : MonoBehaviour
{
    [SerializeField]
    private float waitTime;

    [SerializeField]
    private int direction;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenerateFox());
    }

    IEnumerator GenerateFox()
    {
        if (direction > 0)//run right
        {
            GameObject fox = PoolingManager.Instance.GetPooledObject("FoxAnimalLeftList");
            fox.transform.position = transform.position;
            fox.SetActive(true);
        }
        else//run left            
        {
            GameObject fox = PoolingManager.Instance.GetPooledObject("FoxAnimalRightList");
            fox.transform.position = transform.position;
            fox.SetActive(true);
        }

        yield return new WaitForSeconds(waitTime);

        StartCoroutine(GenerateFox());
    }
}
