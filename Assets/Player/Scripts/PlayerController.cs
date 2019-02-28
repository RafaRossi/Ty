using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerController : MonoBehaviour
{
    public string interactButton;

    public Item holdingItem;

    Vector2 direction;

    PlayerMovement movement;

    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<PlayerMovement>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            RaycastHit2D hit;
            direction = GetRayDirection(movement.direction);
            Debug.DrawRay(transform.position, direction, Color.green, 1f);

            if(hit = Physics2D.Raycast(transform.position, direction, 2))
            {
                hit.collider.gameObject.GetComponent<Interactable>().Interact(this);
            }
            
        }
    }

    public Vector2 GetRayDirection(PlayerDirection direction)
    {
        Vector2 returnDirection = Vector2.zero;
        switch (direction)
        {
            case PlayerDirection.Up:
                returnDirection = transform.up;
                break;
            case PlayerDirection.Down:
                returnDirection = -transform.up;
                break;
            case PlayerDirection.Left:
                returnDirection = -transform.right;
                break;
            case PlayerDirection.Right:
                returnDirection = transform.right;
                break;
        }
        return returnDirection;
    }

    public void SetPickup(Item item)
    {
        holdingItem = item;
    }

    public Item GetPickup()
    {
        return holdingItem;
    }
}
