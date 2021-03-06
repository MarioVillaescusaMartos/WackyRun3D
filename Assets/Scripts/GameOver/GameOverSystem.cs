using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverSystem : MonoBehaviour
{
    private RunnerHealthSystem _healthSystem;

    [SerializeField]
    private GameObject gameOverDisplayUI;

    private void Awake()
    {
        _healthSystem = GetComponent<RunnerHealthSystem>();
    }

    private void OnEnable()
    {
        _healthSystem.OnHealthZero += ShowGameOcerDisplay;
    }

    private void OnDisable()
    {
       _healthSystem.OnHealthZero -= ShowGameOcerDisplay;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    public void ShowGameOcerDisplay()
    {
        if (!GameOverManager.notShowGameOver)
        {
            gameOverDisplayUI.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            gameOverDisplayUI.SetActive(false);
        }
    }
}
