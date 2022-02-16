using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputSystemKeyboard : MonoBehaviour
{ 
    public float hor{ get; private set; } //get sirve para obtener/set para asignar
    public float ver { get; private set; }
    //public bool w { get; private set; }

    public event Action OnFire1 = delegate { }; //Se crea el evento pulico para que hayan clases que se puedan enterar de el (OnFire puede ser cualquier nombre)(delegate: forma de decir que es un evento)
    public event Action OnJump = delegate { };
    public event Action OnCreateFollower = delegate { };
    public event Action OnInvencible = delegate { };
    public event Action OnDeleteFollower = delegate { };
    public event Action OnPause = delegate { };

    private bool pause;
    bool keyPressed;

    // Update is called once per frame
    private void Update()
    {
       /* pause = PauseManager.pauseMode;

        if (!pause)
        {*/
            hor = Input.GetAxis("Horizontal");
            ver = Input.GetAxis("Vertical");
            //w = Input.GetKeyDown(KeyCode.W);

            if (Input.GetKeyDown(KeyCode.W))
            {
                OnJump(); //Cuando se pulsa la tecla "W" el personaje principal salta, y si se le pulsa una segunda vez salta otra vez en el aire
            }
            
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                OnPause(); //Cuando se pulsa la tecla "Esc" el juego se pausa
            }

            //Good mode keys
            //Create Follower
            if (Input.GetKeyDown(KeyCode.P) && Input.GetKeyDown(KeyCode.RightControl))
            {
                OnCreateFollower();
            }

            //Invencible
            if (Input.GetKeyDown(KeyCode.I) && Input.GetKeyDown(KeyCode.RightControl))
            {
                OnInvencible();

            }

        //Delete followers
            if (Input.GetKeyDown(KeyCode.O) && Input.GetKeyDown(KeyCode.RightControl))
            {
                OnDeleteFollower();

            }
        //}
    }

    public bool ReturnKey()
    {
        return keyPressed;
    }
}