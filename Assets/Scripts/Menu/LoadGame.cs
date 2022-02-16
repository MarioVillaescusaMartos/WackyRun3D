using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadGame : MonoBehaviour
{
    [SerializeField]
    private Text infoDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1Scene");
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2Scene");
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level3Scene");
    }
}
