using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb;

    public float dirX;
    public float speed = 20f;

    public float jumpForce = 10.0f;
    private bool isGround;
    public Transform groundCheck;

    public PlayerMove(Transform groundCheck)
    {
        this.groundCheck = groundCheck;
    }

    public LayerMask GroundMask;

    public int extraJumps;
    public int numberJumps;

    void Start()
    {
        rb.GetComponent<Rigidbody2D>();

        extraJumps = numberJumps;
    }


    private void Update()
    {
        isGround = Physics2D.OverlapCircle(groundCheck.position, 0.1f, GroundMask);

        if (isGround == true)
        {
            extraJumps = numberJumps;
        }

        if (Input.GetKeyUp(KeyCode.Space) && extraJumps > 0)
        {
            extraJumps--;
        }

        if (Input.GetKeyDown(KeyCode.Space) && extraJumps > 0)
        {
            extraJumps--;

            rb.velocity = Vector2.up * jumpForce;

        }
        else if (Input.GetKeyDown(KeyCode.Space) && extraJumps == 0 && isGround == true) {  }

            dirX = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(dirX * speed, rb.velocity.y);

    }
}
  