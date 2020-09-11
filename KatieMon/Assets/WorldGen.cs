using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGen : MonoBehaviour
{
    [SerializeField] int worldSize;
    [SerializeField] GameObject selectedTile;
    [SerializeField] bool gen;
    [SerializeField] GameObject hoverTile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gen)
        {
            gen = false;
            GenerateWorld();
        }

        //DetectHoverTile();
        //ChangeTile();
    }

    private void DetectHoverTile()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit.collider != null)
        {
            hoverTile = hit.collider.gameObject;
        }
        else
        {
            hoverTile = null;
        }
    }

    private void ChangeTile()
    {
        if (hoverTile != null && Input.GetMouseButtonDown(0))
        {
            //hoverTile.GetComponent<SpriteRenderer>().sprite = selectedTile;
        }
    }

    private void GenerateWorld()
    {
        for (int i = 0; i < worldSize; i++)
        {
            for (int j = 0; j < worldSize; j++)
            {
                GameObject cell = Instantiate(selectedTile);

                cell.transform.position = new Vector2(i * .16f, j * .16f);
            }
        }
    }
}
