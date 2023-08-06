using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private int baseSpeed = 5;
    public float speedMod = 1f;
    private Rigidbody2D playerBody;
    private float vertical;
    private float horizontal;
    private bool canMove = true;

    public void SetPlayerSpeedModifier(float speedMod)
    {
        this.speedMod = speedMod;
    }

    private void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if(canMove)
        {
            playerBody.velocity = new Vector2(horizontal * baseSpeed * speedMod,
            vertical * baseSpeed * speedMod);
        }
        
    }
}
