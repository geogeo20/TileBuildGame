﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{
    public enum TileType { Empty, Floor };

    TileType type = TileType.Empty;
    public TileType Type { get => type; set => type = value; }



    LooseObject looseObject;
    InstalledObject installedObject;

    World world;
    int x;
    int y;

    

    public Tile(World world, int x, int y)
    {
        this.world = world;
        this.x = x;
        this.y = y;
    }

}
