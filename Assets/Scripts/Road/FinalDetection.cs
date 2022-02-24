using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDetection : MonoBehaviour
{
    [SerializeField]
    private GameObject victoriDisplayUI;
    [SerializeField]
    private GameObject gameOverDisplayUI;
    [SerializeField]
    private int minFollower;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void GetRunner(bool run)
    {
        if (run)
        {
            if (FollowerManager.followers < minFollower)
            {
                gameOverDisplayUI.SetActive(true);
                Time.timeScale = 0f;
            }
            else
            {
                victoriDisplayUI.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }
}
