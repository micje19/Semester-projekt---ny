using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorGrid : MonoBehaviour {
    [SerializeField]
    private int rows = 10;
    [SerializeField]
    private int cols = 4;
    [SerializeField]
    private float tileSize = 2f;
    public GameObject myPrefab;


    void Start()
    {
        CreateGrid();
    }


    private void CreateGrid()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Vector2 pos = transform.position;
                GameObject tile = (GameObject)Instantiate(myPrefab, transform);

                tile.transform.position = pos + new Vector2(-1.16f, 1.87f);
            }
        }
    }
}
