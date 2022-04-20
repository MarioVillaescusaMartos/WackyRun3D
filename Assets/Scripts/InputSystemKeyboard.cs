using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class InputSystemKeyboard : MonoBehaviour
{ 
    public float hor{ get; private set; } //get sirve para obtener/set para asignar
    public float ver { get; private set; }

    public event Action OnCreateFollower = delegate { };
    public event Action OnInvencible = delegate { };
    public event Action OnDeleteFollower = delegate { };
    public event Action OnPause = delegate { };
    public event Action OnEnter = delegate { };
    public event Action OnTp = delegate { };

    private bool pause;
    private bool space;
    bool keyPressed;

    // Update is called once per frame
    private void Update()
    {
        pause = PauseManager.pauseMode;

        if (!pause)
        {
            hor = Input.GetAxis("Horizontal");
            ver = Input.GetAxis("Vertical");
            
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                OnPause(); //Cuando se pulsa la tecla "Esc" el juego se pausa
            }
            
            if (Input.GetKeyDown(KeyCode.F5))
            {
                OnTp();
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && !space)
        {
            OnEnter();
            space = true;
        }

        //Good mode keys          
        //Invencible
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            OnInvencible();
        }

        //Load level 1
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("Level1Scene");
        }

        //Load level 2
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("Level2Scene");
        }

        //Load level 3
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SceneManager.LoadScene("Level3Scene");
        }

        //Create Follower
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            OnCreateFollower();
        }

        //Delete followers
        if (Input.GetKeyDown(KeyCode.Alpha5) && FollowerManager.followers != 0)
        {
            OnDeleteFollower();

        }
    }

    public bool ReturnKey()
    {
        return keyPressed;
    }
}