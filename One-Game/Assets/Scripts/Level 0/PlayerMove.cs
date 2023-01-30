using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;

    float dirX;
    public float speed = 20f;

    public float jumpForce = 10.0f;
    private bool isGround;
    public Transform groundCheck;
    public LayerMask GroundMask;

    public int extraJumps;
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        isGround = Physics2D.OverlapCircle(groundCheck.position, 0.1f, GroundMask);

        if (isGround == true)
        {
            extraJumps = 10;
        }

        if (Input.GetKeyDown(KeyCode.Space) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce;

            --extraJumps;

        }else if(Input.GetKeyDown(KeyCode.Space) && extraJumps == 0 && isGround == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }

        dirX = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(dirX * speed, rb.velocity.y);

    }
}
