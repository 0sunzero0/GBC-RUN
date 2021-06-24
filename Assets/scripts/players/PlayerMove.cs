using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float speed = 0.5f; //속도
    private Transform playersTf; //참조를 위해
    private Vector3 playerPos; //플레이어 위치값

    void Awake()
    {
        playersTf = transform; //현재 스크립트 가지고 있는 자신의 transform
    }
    // Use this for initialization
    void Start ()
    {
        playerPos = playersTf.position;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        playerPos.x += speed;
        playersTf.position = playerPos;
	}
}
