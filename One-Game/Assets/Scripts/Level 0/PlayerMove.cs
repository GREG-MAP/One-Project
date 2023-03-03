using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb;

    public float dirX;
    public float speed = 20f;

    public float jumpForce = 10f;
    private bool isGround;
    public Transform groundCheck;
    public LayerMask GroundMask;

    public float ySpeed;

    public int extraJumps;
    public int numberJumps;
    public PlayerMove(Transform groundCheck)
    {
        this.groundCheck = groundCheck;
    }
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();

        extraJumps = numberJumps;
    }

    private void Update()
    {

        isGround = Physics2D.OverlapCircle(groundCheck.position, 0.0001f, GroundMask);

        if (isGround == true)
        {
            extraJumps = numberJumps;

            ySpeed = Mathf.Clamp(ySpeed, -0.5f, 100);

        }else{ 

            ySpeed = Mathf.Clamp(ySpeed, -100f, 100); 

        }


        if (Input.GetKeyUp(KeyCode.Space))
        {
            extraJumps--;
        }

        dirX = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(dirX * speed, ySpeed);

        if (Input.GetKeyDown(KeyCode.Space) && extraJumps > 0)
        {
            ySpeed = 13f;
        }
        
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed * 1.5f;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 20f;
        }

        ySpeed += Physics2D.gravity.y * Time.deltaTime * 2f;


    }
}
  