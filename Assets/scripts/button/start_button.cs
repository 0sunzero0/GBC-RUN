using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_button : MonoBehaviour {

    // Use this for initialization  
    void Awake()
    {
    }

    public void StartButton()
    {
        Invoke("startgame", .5f);
    }

    void startgame()
    {
        Application.LoadLevel("first_day");
    }

}
