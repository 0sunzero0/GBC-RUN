using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPbar : MonoBehaviour {
    public GameObject bar_1;
    public GameObject bar_2;
    public GameObject bar_3;
    public GameObject bar_4;
    public GameObject bar_5;
    public GameObject bar_6;
    public GameObject bar_7;
    public GameObject bar_8;
    public GameObject bar_9;
    public GameObject bar_10;
    public GameObject bar_11;
    public GameObject temp;
    public int hp = 100;

    // Use this for initialization
    void Start () {
        bar_1.active = true;
        temp = bar_1;
        bar_2.active = false;
        bar_3.active = false;
        bar_4.active = false;
        bar_5.active = false;
        bar_6.active = false;
        bar_7.active = false;
        bar_8.active = false;
        bar_9.active = false;
        bar_10.active = false;
        bar_11.active = false;
    }

    // Update is called once per frame
    void Update() {
        if (hp > 90 && hp <= 100)
        {
            temp.active = false;
            temp = bar_1;
            temp.active = true;
        }
        else if (hp > 80 && hp <= 90)
        {
            temp.active = false;
            temp = bar_2;
            temp.active = true;
        }
        else if (hp > 70 && hp <= 80)
        {
            temp.active = false;
            temp = bar_3;
            temp.active = true;
        }
        else if (hp > 60 && hp <= 70)
        {
            temp.active = false;
            temp = bar_4;
            temp.active = true;
        }
        else if (hp > 50 && hp <= 60)
        {
            temp.active = false;
            temp = bar_5;
            temp.active = true;
        }
        else if (hp > 40 && hp <= 50)
        {
            temp.active = false;
            temp = bar_6;
            temp.active = true;
        }
        else if (hp > 30 && hp <= 40)
        {
            temp.active = false;
            temp = bar_7;
            temp.active = true;
        }
        else if (hp > 20 && hp <= 30)
        {
            temp.active = false;
            temp = bar_8;
            temp.active = true;
        }
        else if (hp > 10 && hp <= 20)
        {
            temp.active = false;
            temp = bar_9;
            temp.active = true;
        }
        else if (hp > 0 && hp <= 10)
        {
            temp.active = false;
            temp = bar_10;
            temp.active = true;
        }
        else if (hp <= 0)
        {
            temp.active = false;
            temp = bar_11;
            temp.active = true;
            Application.LoadLevel("dead");
        }
        
	}
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            hp -= 10;
        }
        if (col.gameObject.tag == "item1")
        {
            if (hp <= 98)
                hp += 2;
        }
        if (col.gameObject.tag == "item2")
        {
            if (hp == 98)
                hp += 2;
            if (hp == 96)
                hp += 4;
            if (hp == 94)
                hp += 6;
            if (hp == 92)
                hp += 8;
            if (hp <= 90)
                hp += 10;
        }
    }
}
