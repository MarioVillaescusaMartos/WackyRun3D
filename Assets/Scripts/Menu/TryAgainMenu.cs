using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TryAgainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOversUI;


    // Start is called before the first frame update
    void Start()
    {

    }

    public void TryAgain()
    {
        //System.GC.Collect();

        //gameOversUI.SetActive(false);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        FollowerManager.followers = 0;  

        Time.timeScale = 1f;
    }
}
