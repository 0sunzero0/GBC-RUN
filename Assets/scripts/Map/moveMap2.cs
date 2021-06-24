using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMap2 : MonoBehaviour
{
    public GameObject tile;
    private int tileNum = 6;

    struct TileStruct
    {
        public GameObject obj;
        public Transform tf;
        public bool active;
        public Vector3 pos;
    }
    private TileStruct[] tiles;

    private Vector3 tileCenterVec;
    private float tileGap = 9f;
    private float tileEndPoint = -20f;

    private Vector3 tempVec;
    private float speed = 0.18f;
    private int lastTileNum = 0;


    void Awake()
    {
        tileCenterVec = new Vector3(-11.77f, -1.7f, 0);
        CreateTiles();

    }
    private void Update()
    {
        for (int i = 0; i < tileNum; i++)
        {
            tiles[i].pos.x -= speed;
            if (tiles[i].pos.x > tileEndPoint)
            {
                tiles[i].tf.position = tiles[i].pos;
            }
            else
            {


                tiles[i].pos = tiles[lastTileNum].pos;
                tiles[i].pos.x += tileGap;
                if (lastTileNum > i)
                {
                    tiles[i].pos.x -= 0.5f;
                }

                tiles[i].tf.position = tiles[i].pos;

                lastTileNum = i;
            }
        }
    }



    void CreateTiles()
    {
        tempVec = tileCenterVec;

        tiles = new TileStruct[tileNum];
        for (int i = 0; i < tileNum; i++)
        {
            tiles[i].obj = Instantiate(tile, tempVec, Quaternion.identity) as GameObject;
            tiles[i].tf = tiles[i].obj.transform;
            tiles[i].pos = tiles[i].tf.position;
            tiles[i].active = true;

            tempVec.x += tileGap;
        }
        lastTileNum = 5;
    }

}
