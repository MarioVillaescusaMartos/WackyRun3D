using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsCanvas : MonoBehaviour
{
    [SerializeField]
    private Text coinsDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinsDisplay.text = "Total Coins: " + CoinsManager.coins.ToString();
    }
}
