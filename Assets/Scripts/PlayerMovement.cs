using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    private float directionX = 0f;

    private float directionY = 0f;

    public float movementSpeed = 7f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        directionX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(directionX * movementSpeed, rb.velocity.y);

        directionY = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(rb.velocity.x,directionY *movementSpeed);
    }
}
