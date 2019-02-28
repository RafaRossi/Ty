using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seeds : Item
{
    public Seed seed;

    SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    
    public void SetSeed(Seed seed)
    {
        this.seed = seed;
        sprite.sprite = seed.sprite;
    }

    public Seed GetSeed()
    {
        return seed;
    }
}
