using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class re_button : MonoBehaviour {

    // Use this for initialization  
    void Awake()
    {
    }

    public void StartButton()
    {
        Invoke("regame", .5f);
    }

    void regame()
    {
        Application.LoadLevel("first_day");
    }
}


