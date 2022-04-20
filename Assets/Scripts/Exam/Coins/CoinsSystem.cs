using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsSystem : MonoBehaviour
{
    [SerializeField]
    private int coinValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CoinIncrement()
    {
        CoinsManager.coins += coinValue;

        gameObject.SetActive(false);
    }
}
