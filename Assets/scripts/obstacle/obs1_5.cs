using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obs1_5 : MonoBehaviour
{
    public GameObject obs;
    public float speed = 7.2f;
    private void Start()
    {
        obs.transform.localPosition = new Vector3(10.20f, -2.02f, 0);

    }
    void Update()
    {

        obs.transform.position -= new Vector3(speed * Time.deltaTime * (1), 0, 0);
        //obs.transform.position = new Vector3(188.04f, -0.44f, 0);


    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("충돌 : " + col.name);
    }
}