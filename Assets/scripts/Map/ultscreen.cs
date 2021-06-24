using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ultscreen : MonoBehaviour
{
    public GameObject obs;
    private void Start()
    {
        obs.active = true;
        Destroy(obs, 2);

    }
    void Update()
    {

    }
  
}
