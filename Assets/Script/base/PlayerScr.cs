using UnityEngine;
using System.Collections;

public class PlayerScr : MonoBehaviour {

    public static PlayerScr instance;
    public float speed, jumpPower;

    private Transform tr;
    private Rigidbody2D rb;

    public bool isGrounded;
    private Transform m_GroundCheck;
    const float k_GroundedRadius = .2f;
    private bool m_FacingRight = true;
    private float mySpeed = 0;
    public int gameSide = 0;



    private bool isW = true;//for keyboard
    void Awake()
    {
        if (instance == null)
            instance = this;
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        isGrounded = false;
        m_GroundCheck = transform.Find("GroundCheck");
    }



	// Use this for initialization
	void Start () {

	}

    public void jump()
    {
        if(isGrounded)
        {
            if (gameSide == 0)
                rb.AddForce(new Vector2(0, jumpPower));
            else if (gameSide == 1)
            {
                rb.AddForce(new Vector2(-jumpPower, 0));
            }
            
        }
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        Collider2D[] colliders = Physics2D.OverlapCircleAll(m_GroundCheck.position, k_GroundedRadius);
        isGrounded = false;
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject)
                isGrounded = true;
        }


        //keyboardMove();
        if(mySpeed != 0)
        {
            if(gameSide == 0)
                rb.velocity = new Vector2(mySpeed, rb.velocity.y);
            else if(gameSide == 1)
                rb.velocity = new Vector2(rb.velocity.x, mySpeed);
        }


    }

    public void goLeft()
    {
        mySpeed = -speed;
        if (m_FacingRight) Flip();
    }

    public void goRight()
    {
        mySpeed = speed;
        if (!m_FacingRight) Flip();
    }

    public void goJump()
    {
        jump();
    }

    public void goStop()
    {
        mySpeed = 0;
        if (gameSide == 0)
            rb.velocity = new Vector2(0, rb.velocity.y);
        else if (gameSide == 1)
            rb.velocity = new Vector2(rb.velocity.x, 0);


    }



    void Update()
    {

    }


    private void keyboardMove()
    {
        if (gameSide != 0)
            return;
        if (Input.GetKey(KeyCode.W))
        {
            if (isW)
                jump();
            isW = false;
        }
        else
            isW = true;

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            if (m_FacingRight) Flip();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            if (!m_FacingRight) Flip();
        }
        else
            rb.velocity = new Vector2(0, rb.velocity.y);

        if (Input.GetKey(KeyCode.S))
        {
        }
    }


    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

}
