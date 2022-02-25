using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterGame : MonoBehaviour
{
    private InputSystemKeyboard _inputSystem;

    [SerializeField]
    private GameObject gameEnterUI;

    private void Awake()
    {
        _inputSystem = GetComponent<InputSystemKeyboard>();
    }

    private void OnEnable()
    {
        _inputSystem.OnEnter += GameEnter;
    }

    private void OnDisable()
    {
        _inputSystem.OnEnter -= GameEnter;
    }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;

        PauseManager.pauseMode = true;
    }

    private void GameEnter()
    {
        gameEnterUI.SetActive(false);

        PauseManager.pauseMode = false;

        Time.timeScale = 1f;
    }
}
