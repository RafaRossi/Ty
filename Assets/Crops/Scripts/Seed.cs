using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Seed", menuName = "Seeds")]
public class Seed : Crop
{
    public Sprite sprite;
    public Ingredient grownUpSeed;
    public float timeToGrow;
    
    public Ingredient Grow()
    {
        return grownUpSeed;
    }
}
