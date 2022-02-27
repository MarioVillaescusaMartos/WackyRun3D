using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadCredits : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void EnterCredits()
    {
        SceneManager.LoadScene("CreditsScene");

        Time.timeScale = 1f;
    }
}
