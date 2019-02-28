using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapEditor : MonoBehaviour
{
    public Texture2D map;

    public Tilemap tmap;

    public MapInfo[] maps;

    // Start is called before the first frame update
    void Start()
    {
        GenerateLevel();
    }

    public void GenerateLevel()
    {
        for (int x = 0; x < map.width; x++)
        {
            for (int y = 0; y < map.height; y++)
            {
                GenerateTile(x, y);
            }
        }
    }

    void GenerateTile(int x, int y)
    {
        Color color = map.GetPixel(x, y);

        if (color.a == 0)
            return;

        foreach (MapInfo info in maps)
        {
            if (info.color.Equals(color))
            {
                Vector3Int pos = new Vector3Int(x, y, 0);
                tmap.SetTile(pos, info.ruleTile);
            }
        }
    }
}

[System.Serializable]
public class MapInfo
{
    public Color color;
    public RuleOverrideTile ruleTile;
}
