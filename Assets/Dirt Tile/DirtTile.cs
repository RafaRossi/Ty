using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtTile : MonoBehaviour, Interactable
{
    private bool readyToHarvest;
    Seed seed;

    public void Interact(PlayerController player)
    {
        if (this.seed.Equals(null))
        {
            Seed seed = player.holdingItem.GetComponent<Seed>();

            if (!seed.Equals(null))
            {
                StartCoroutine(Plant(seed));
            }
        }
        else
        {
            if (player.holdingItem.Equals(null))
            {
                if (readyToHarvest)
                {
                    Ingredients ingredients = new Ingredients();

                    ingredients.SetIngredient(Harvest());
                    player.SetPickup(ingredients);

                    Plant(null);
                }
            }
        }
    }

    IEnumerator Plant(Seed seed)
    {
        this.seed = seed;

        if (this.seed != null)
        {
            yield return new WaitForSeconds(seed.timeToGrow);
            readyToHarvest = true;
        }
    }

    Ingredient Harvest()
    {
        readyToHarvest = false;
        return seed.Grow();
    }
}
