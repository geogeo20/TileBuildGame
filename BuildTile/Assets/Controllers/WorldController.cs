using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class WorldController : MonoBehaviour
{
    public Sprite floorSprite;
    
    World world;
    
    
    // Start is called before the first frame update
    void Start()
    {
        world = new World();
        
        for (int x = 0; x < world.Width; x++)
        {
            for (int y = 0; y < world.Height; y++)
            {
                Tile tileData = world.GetTileAt(x, y);
                
                GameObject tileGo = new GameObject();
                tileGo.name = "Tile_" + x + "_" + y;
                tileGo.transform.position = new Vector3(tileData.X, tileData.Y, 0);
                tileGo.AddComponent<SpriteRenderer>();

                

            }
        }
        world.RandomizeTiles();

    }

    private float randomizeTileTImer = 2f;
    

    // Update is called once per frame
    void Update()
    {
        randomizeTileTImer -= Time.deltaTime;

        if (randomizeTileTImer < 0)
        {
            world.RandomizeTiles();
            randomizeTileTImer = 2f;
            
        }
    }

    void OnTileTypeChanged(Tile tileData, GameObject tileGo)
    {
        if (tileData.Type == Tile.TileType.Floor)
        {
            tileGo.gameObject.GetComponent<SpriteRenderer>().sprite = floorSprite;
        }
        else if (tileData.Type == Tile.TileType.Empty)
        {
            tileGo.gameObject.GetComponent<SpriteRenderer>().sprite = null;
        }
        else
        {
            Debug.LogError("Unrecognized tile type");
        }

    }

}
