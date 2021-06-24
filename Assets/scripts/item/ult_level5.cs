using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ult_level5 : MonoBehaviour
{
    public GameObject obs;
    public float speed = 18.2f;
    private void Start()
    {

    }
    void Update()
    {
        obs.transform.position -= new Vector3(speed * Time.deltaTime * (1), 0, 0);

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        obs.active = false;
        Application.LoadLevel("ending");
    }


}