/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAction : MonoBehaviour {
    bool jumpOn = false;
    float jumpPower = 0.75f;
    float tempJump;
    Transform playerTf;
    Vector3 tempVec;
    void Awake()
    {
        playerTf = transform;
    }

    void Update()
    {
        if (!jumpOn)
        {
            if ((Input.GetMouseButtonDown(0) || Input.GetButtonDown("Jump")))
            {
                StartCoroutine("JumpAction");
            }
        }
        
    }

    IEnumerator JumpAction()
    {
        jumpOn = true;
        tempVec = playerTf.position;

        tempJump = jumpPower;
        tempVec.y += tempJump;
        playerTf.position = tempVec;

        while (tempVec.y > 0.76f)
        {
            yield return new WaitForSeconds(0.03f);
            tempJump -= 0.05f;
            tempVec.y += tempJump;
            playerTf.position = tempVec;
        }
        tempVec.y = 0.76f;
        playerTf.position = tempVec;
        jumpOn = false;
    }
    
}*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAction : MonoBehaviour
{
    bool jumpOn = false; //점프 시작을 위해 //점프 했는지 안했는지 확인을 위해
    bool doublejumpOn = false;
    float jumpPower = 0.75f;
    float tempJump;
    Transform playerTf;
    Vector3 tempVec;

    void Awake()
    {
        playerTf = transform;
    }

    void Update()
    {   //스페이스 입력 1단 점프
        if (!jumpOn)
        {
            if ((Input.GetMouseButtonDown(0) || Input.GetButtonDown("Jump")))
            {
                StartCoroutine("JumpAction");
            }
        }
        //1단 점프하는데 입력 들어오면 2단 점프
        else if ((!doublejumpOn && jumpOn) && (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Jump")))
        {
            StartCoroutine("DoubleJumpAction");
            StopCoroutine("JumpAction");
        }
    }

    IEnumerator JumpAction()
    {
        jumpOn = true;
        tempVec = playerTf.position;

        tempJump = jumpPower;
        tempVec.y += tempJump;
        playerTf.position = tempVec;

        while (tempVec.y > 0.76f)
        {
            yield return new WaitForSeconds(0.03f);
            tempJump -= 0.05f;
            tempVec.y += tempJump;
            playerTf.position = tempVec;
        }
        tempVec.y = 0.76f;
        playerTf.position = tempVec;
        jumpOn = false;
    }

    IEnumerator DoubleJumpAction()
    {
        jumpOn = true;
        doublejumpOn = true;
        tempVec = playerTf.position;

        tempJump = jumpPower;
        tempVec.y += tempJump;
        playerTf.position = tempVec;

        while (tempVec.y > 0.76f)
        {
            yield return new WaitForSeconds(0.03f);
            tempJump -= 0.05f;
            tempVec.y += tempJump;
            playerTf.position = tempVec;
        }
        tempVec.y = 0.76f;
        playerTf.position = tempVec;
        doublejumpOn = false;
        jumpOn = false;
    }
}