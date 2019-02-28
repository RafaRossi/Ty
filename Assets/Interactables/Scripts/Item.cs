using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour, Interactable
{
    public GameObject prefab;

    public virtual void Interact(PlayerController player)
    {
        Debug.Log("foi");
    }
}
