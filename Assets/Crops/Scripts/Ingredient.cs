using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crop : ScriptableObject
{

}

[CreateAssetMenu(fileName = "New Ingredient", menuName = "Ingredient")]
public class Ingredient : Crop
{
    public Sprite sprite;

    [Header("Cut Options")]
    public bool cuttable;
    public bool isCutted;
    public Ingredient cuttableIngredient;

    [Header("Cook Options")]
    public bool cookable;
    public bool isCooked;
    public bool isBurned;
    public Ingredient cookableIngredient;

    [Header("Put Option")]
    public bool canPutOnPlate;
    public bool canPutOnPan;
    public bool canPutOnFrying;

    public Ingredient Cut()
    {
        if (!isCutted)
        {
            if (cuttable)
                return cuttableIngredient;
        }
        return null;
    }

    public Ingredient Cook()
    {
        if(!isCooked)
        {
            if (cookable)
                return cookableIngredient;
        }
        return null;
    }

    public bool CanCook()
    {
        return cookable;
    }

    public bool CanCut()
    {
        return cuttable;
    }

}
