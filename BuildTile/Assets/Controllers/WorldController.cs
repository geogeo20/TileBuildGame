﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour
{
    World world;
    // Start is called before the first frame update
    void Start()
    {
        world = new World();
        world.RandomizeTiles();

        for (int x = 0; x < world.Width; x++)
        {
            for (int y = 0; y < world.Height; y++)
            {
                GameObject tile_go = new GameObject();
                tile_go.name = "Tile_" + x + "_" + y;
                SpriteRenderer tile_sr = tile_go.AddComponent<SpriteRenderer>();

                Tile tile_data = world.GetTileAt(x, y);

                if(tile_data.Type == Tile.TileType.Floor)

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
