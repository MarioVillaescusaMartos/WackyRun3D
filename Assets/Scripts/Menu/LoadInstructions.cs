using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInstructions : MonoBehaviour
{
    [SerializeField]
    private GameObject gameInstructionsUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void EnterInstructions()
    {
        gameInstructionsUI.SetActive(true);
    }

    public void ExitInstructions()
    {
        gameInstructionsUI.SetActive(false);
    }
}
