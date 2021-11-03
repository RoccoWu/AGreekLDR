using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    public int numJump;
    public int maxJump;

    public float jumpForce;

    public bool touchGround;
    
    private Rigidbody2D rb;

    public HealthBar healthBar;
    public GameManager gm;

    void Start()
    {
        maxJump = 1;

        numJump = maxJump;
        rb = gameObject.GetComponent<Rigidbody2D>();
        touchGround = false;       
    }

    void Update()
    {
        // on space...
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // check if we can jump
            if (numJump > 0)
            {
                numJump--;
                Debug.Log("Jump!");
                rb.AddForce(new Vector3(0.0f, jumpForce, 0.0f));
                touchGround = false;                
                FindObjectOfType<AudioController>().Play("jump");
            }
        }

        //fall faster
        if(Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(new Vector3(0.0f, -jumpForce, 0.0f));
        }

        if(healthBar.health <= 0)
        {
            gm.gameOver = true;
        }

       /* if(Input.GetKeyDown(KeyCode.W))
        {
            healthBar.TakeDamage(20);
        }
       */
    }

    void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.tag == "Ground")
        {
            numJump = maxJump;
            touchGround = true;
        }  


        if (hit.gameObject.tag == "Obstacle")
        {
            healthBar.TakeDamage(20);
            // Hades and Persephone share lives
            
        }
    }
}