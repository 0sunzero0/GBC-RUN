using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obs2_3 : MonoBehaviour
{
    public GameObject obs;
    public float speed = 7.2f;
    private void Start()
    {
        obs.transform.position = new Vector3(341.3f, 1.08f, 0);

    }
    void Update()
    {

        obs.transform.position -= new Vector3(speed * Time.deltaTime * (1), 0, 0);


    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("충돌 : " + col.name);
    }
}