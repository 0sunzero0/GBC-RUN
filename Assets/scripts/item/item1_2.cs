using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item1_2 : MonoBehaviour
{
    public GameObject obs;
    public float speed = 7.2f;
    private void Start()
    {
        obs.transform.localPosition = new Vector3(12.56f, 1.66f, 0);

    }
    void Update()
    {
        obs.transform.position -= new Vector3(speed * Time.deltaTime * (1), 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        obs.active = false;
    }
}