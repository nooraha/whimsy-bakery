using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private int baseSpeed = 5;
    public float speedModifier = 1f;
    private Rigidbody2D playerBody;
    private Vector2 velocity;
    private Vector2 inputMovement;

    public void SetPlayerSpeedModifier(float speedModifier)
    {
        this.speedModifier = speedModifier;
    }

    private void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        velocity = new Vector2(baseSpeed, baseSpeed);
    }

    private void Update()
    {
        inputMovement = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
            );
    }

    private void FixedUpdate()
    {
        Vector2 delta = inputMovement * velocity * Time.deltaTime * speedModifier;
        Vector2 newPosition = playerBody.position + delta;
        playerBody.MovePosition(newPosition);
    }
}
