using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RunnerAudioController : MonoBehaviour
{
    private AudioSource _auso;
    private InputSystemKeyboard _inputSystem;

    private void Awake()
    {
        _auso = GetComponent<AudioSource>();
        _inputSystem = GetComponent<InputSystemKeyboard>();
    }

    private void OnEnable()
    {
        _inputSystem.OnPause += PauseSound;
    }

    private void OnDisable()
    {
        _inputSystem.OnPause -= PauseSound;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
    }

    private void PauseSound()
    {
        _auso.Pause();
    }

}
