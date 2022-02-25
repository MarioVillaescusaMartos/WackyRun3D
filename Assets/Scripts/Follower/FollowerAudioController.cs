using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerAudioController : MonoBehaviour
{
    private AudioSource _auso;
    private FollowerHealthSystem _follhealth;

    private void Awake()
    {
        _auso = GetComponent<AudioSource>();
        _follhealth = GetComponent<FollowerHealthSystem>();
    }

    private void OnEnable()
    {
        _follhealth.OnHealthZero += PlaySound;
    }

    private void OnDisable()
    {
        _follhealth.OnHealthZero -= PlaySound;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void PlaySound()
    {
        _auso.Play();
    }
}
