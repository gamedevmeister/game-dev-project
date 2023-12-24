using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Grid : MonoBehaviour
{
    public int size;
    //The [,] adds a dimension to the array
    //Cell[,] grid;

    public Vector3Int position;

    void Start()
    {
        GameObject referenceGrass = (GameObject)Instantiate(Resources.Load("Grass"));
        //grid = new Cell[size, size];
        for (int i = 0; i<size; i++)
        {
            for (int j = 0; j<size; j++)
            {
                GameObject tile = (GameObject)Instantiate(referenceGrass, transform);

                float posX = i;
                float posY = -j;

                tile.transform.position = new Vector2(posX, posY);
            }
        }
        Destroy(referenceGrass);


    }
}
