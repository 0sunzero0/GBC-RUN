using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obs1_level3 : MonoBehaviour
{
    public GameObject obs;
    public float speed = 12.2f;
    private void Start()
    {


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
