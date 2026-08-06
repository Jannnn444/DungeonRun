using UnityEngine;

public class PlayerHeroMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    public float speed = 5f;
    public float jump = 5f;
    float movement;
    bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log("碰到地面了");
            anim.SetBool("jump", false);

        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            isGrounded = false;
            Debug.Log("離開地面了");

        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow)) {
            // rb.linearVelocityX = 5f;
            movement = speed;
            anim.SetBool("run", true);
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            // rb.linearVelocityX = -5f;
            movement = -speed;
            anim.SetBool("run", true);
        } else {
            // rb.linearVelocityX = 0f;
            movement = 0f;
            anim.SetBool("run", false);
        }
        rb.linearVelocityX = movement;
        if (Input.GetKey(KeyCode.Space) && isGrounded == true)
        {
            rb.linearVelocity = new Vector2(movement, jump); 
            anim.SetBool("jump", true);
        }
    }
}

