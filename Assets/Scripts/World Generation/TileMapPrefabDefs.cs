﻿using UnityEngine;
using System.Collections;

[System.Serializable]
public struct TileMapPrefabDef
{

    public string Name;
    public TileMapPrefabBuilder tileMapPrefab;
    public bool unique;
    public int rarity;
    public Vector2 coords;
    public int linkageNumber;

    private int _linkages;
    public int linkages
    {
        get
        {
            return _linkages;
        }
        set
        {
            _linkages = value;
        }
    }
}

public class TileMapPrefabDefs : MonoBehaviour
{

    public TileMapPrefabDef[] prefabTypes;
}
