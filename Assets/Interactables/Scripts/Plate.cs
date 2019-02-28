using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : Item
{
    List<Ingredient> ingredients = new List<Ingredient>();

    public override void Interact(PlayerController player)
    {
        Debug.Log("ok");
        Item item = player.GetPickup();

        if (item != null)
        {
            if (item is Ingredients)
            {
                Ingredient ingredient = item.GetComponent<Ingredients>().GetIngredient();
                AddIngredient(ingredient);
            }
            else
            {
                Instantiate(item.prefab);
            }
        }
        player.SetPickup(new Plate());

        Destroy(gameObject);
    }

    public void AddIngredient(Ingredient ingredient)
    {
        if (ingredient.canPutOnPlate)
        {
            ingredients.Add(ingredient);
            Debug.Log("adicionou");
        }
        else Debug.Log("nao pode");
    }
}
