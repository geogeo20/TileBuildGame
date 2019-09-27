using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World
{
    Tile[,] tiles;
    int width;
    int height;

    public int Width { get => width; set => width = value; }
    public int Height { get => height; set => height = value; }



    public World(int width = 100, int height = 100)
    {
        this.Width = width;
        this.Height = height;

        tiles = new Tile[width, height];

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                tiles[x, y] = new Tile(this, x, y);
            }
        }

        Debug.Log("Word created with" + (width * height) + " tiles");

    }

    public void RandomizeTiles()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                if (Random.Range(0, 2) == 0)
                    tiles[x, y].Type = Tile.TileType.Empty;
                else
                    tiles[x, y].Type = Tile.TileType.Floor;
            }
        }
    }
    

    public Tile GetTileAt(int x, int y)
    {
        if (x > Width || x < 0 || y > Height || y < 0)
        {
            Debug.LogError("Tile ( " + x + " " + y + " ) is out of bounds");
            return null;
        }


        return tiles[x, y];
    }



}
