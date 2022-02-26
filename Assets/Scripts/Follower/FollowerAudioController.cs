using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerAudioController : MonoBehaviour
{
    private AudioSource _auso;
    private FollowerHealthSystem _follhealth;
    private bool active;

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
        active = false;
    }

    private void Update()
    {
        if (PauseManager.pauseMode)
        {
            _auso.Pause();
        }
        else if (!PauseManager.pauseMode && active)
        {
            _auso.Play();
        }
    }

    private void PlaySound()
    {
        _auso.Play();

        active = true;
    }
}
