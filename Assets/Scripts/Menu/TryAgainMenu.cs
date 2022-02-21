using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TryAgainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOversUI;


    // Start is called before the first frame update
    void Start()
    {

    }

    public void Update()
    {
        
    }

    public void TryAgain()
    {
        System.GC.Collect();

        gameOversUI.SetActive(false);

        Time.timeScale = 1f;
    }
}
