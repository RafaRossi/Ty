using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredients : Item
{
    public Ingredient ingredient;

    SpriteRenderer sprite;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        SetIngredient(ingredient);
    }

    public override void Interact(PlayerController player)
    {
        Debug.Log("ok");
        Item item = player.GetPickup();

        if (item != null)
        {
            if (item is Plate)
            {
                Plate plate = item.GetComponent<Plate>();
                plate.AddIngredient(ingredient);
            }
            else
                player.SetPickup(this);
        }
        else player.SetPickup(this);
    }

    public void SetIngredient(Ingredient ingredient)
    {
        if (ingredient == null)
            return;

        this.ingredient = ingredient;
        sprite.sprite = ingredient.sprite;
    }

    public Ingredient GetIngredient()
    {
        return ingredient;
    }
}
