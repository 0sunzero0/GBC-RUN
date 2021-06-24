using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item1 : MonoBehaviour
{
    public GameObject obs;
    public float speed = 7.2f;
    private void Start()
    {
        //obs = this.transform.gameObject;
       // obs.transform.position = new Vector3(31.78f, 2.27f, 0);
        //obs.transform.position = new Vector3(31.78f, 2.27f, 0);
        //Invoke("Update" ,0.25f);

    }
    void Update()
    {

        obs.transform.localPosition -= new Vector3(speed * Time.deltaTime * (1), 0, 0);
        

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        obs.active = false;
    }
}
