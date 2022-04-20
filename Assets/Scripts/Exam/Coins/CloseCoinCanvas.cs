using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseCoinCanvas : MonoBehaviour
{
    [SerializeField]
    private GameObject coinsDisplayUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CloseCoinsWindow()
    {
        coinsDisplayUI.SetActive(false);
    }
}
