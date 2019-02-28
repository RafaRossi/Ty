using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerDirection
{
    Up, Down, Left, Right
}

public class PlayerMovement : MonoBehaviour
{
    public string horizontalAxis;
    public string verticalAxis;
    public string runningButton;

    public float currentSpeed;
    public float walkSpeed;
    public float runningSpeed;

    public int playerNum;

    public PlayerDirection direction = PlayerDirection.Down;

    private bool isRunning;

    private float horizontal;
    private float vertical;

    PlayerController controller;
    Rigidbody2D rb;
    Vector2 moveDirection = Vector2.zero;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        controller = GetComponent<PlayerController>();
    }

    void Update()
    {
        isRunning = Input.GetKey(KeyCode.Space);

        horizontal = Input.GetAxis(horizontalAxis);
        vertical = Input.GetAxis(verticalAxis);

        direction = horizontal > 0 ? PlayerDirection.Right : horizontal < 0 ? PlayerDirection.Left : direction;
        direction = vertical > 0 ? PlayerDirection.Up : vertical < 0 ? PlayerDirection.Down : direction;

        switch (direction)
        {
            case PlayerDirection.Up:

                break;
            case PlayerDirection.Down:

                break;
            case PlayerDirection.Left:

                break;
            case PlayerDirection.Right:

                break;
        }
    }
    
    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        currentSpeed = isRunning ? runningSpeed : walkSpeed;

        moveDirection = new Vector2(horizontal * currentSpeed, vertical * currentSpeed);
        rb.velocity = moveDirection;
    }

    public void SetAxis(int num)
    {
        horizontalAxis = "Horizontal " + num;
        verticalAxis = "Vertical " + num;

        runningButton = "Run " + num;

        controller.interactButton = "Interact " + num;
    }
}
