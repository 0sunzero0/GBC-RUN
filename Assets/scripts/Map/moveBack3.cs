using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBack3 : MonoBehaviour
{
    public GameObject background;
    public float speed = 1f;

    private void Start()
    {
        background.transform.position = new Vector3(123.64f, 7.65f, 0);

    }

    // Update is called once per frame
    void Update()
    {

        background.transform.position -= new Vector3(speed * Time.deltaTime * (1), 0, 0);
        if (background.transform.position.x < -40.0f)
        {

            background.transform.position = new Vector3(120f, 7.65f, 0);
        }

    }
}