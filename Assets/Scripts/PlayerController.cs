using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 150f;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
    }


    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x < Screen.width / 2)
            {
                //move left
                rb.velocity = Vector2.left * moveSpeed * Time.deltaTime;
                spriteRenderer.flipX = true;

            }
            else
            {
                //move right
                rb.velocity = Vector2.right * moveSpeed * Time.deltaTime;
                spriteRenderer.flipX = false;
            }

        }
    }
}
