using UnityEngine;
using System.Collections;
using UnityEngine.XR;

public class scr : MonoBehaviour
{
    public Rigidbody2D rb;
    private float speed = 1f;
    public float jumpSpeed = 10f;
    float inputHorizontal;
    private Animator anim;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");

        //jumping
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(rb.velocity.y, jumpSpeed));
        }

        //moving the player
        if (inputHorizontal != 0)
        {
            rb.AddForce(new Vector2(inputHorizontal * speed, 0f));
        }

        //Flipping the player when you move a different direction
        if (inputHorizontal < 0f)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
        if (inputHorizontal > 0f)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }

        //Idle animation
        if (inputHorizontal == 0)
        {
            anim.SetBool("isIdle", true);
        }
        else
        {
            anim.SetBool("isIdle", false);
        }

        //Reset button
        if (Input.GetKey(KeyCode.R))
        {
            transform.position = new Vector2(0, 0);
        }
    }
}