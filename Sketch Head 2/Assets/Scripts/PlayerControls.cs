using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    public Rigidbody2D rb;
    public float downSpeed = 20f;
    public float movementSpeed = 10f;
    public float movement = 0f;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent < Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        spriteRenderer.flipX = movement < 0;
    }

    void FixedUpdate() {
        Vector3 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (rb.velocity.y <= 0) {
            rb.velocity = new Vector2(rb.velocity.x, downSpeed);
        }
    }
}
