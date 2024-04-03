using UnityEngine;
using System.Collections;

public class scr : MonoBehaviour
{
    public Rigidbody2D rb;
    private float speed = 1000f;
    private float jumpSpeed = 400000f;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-speed * Time.deltaTime, 0f));
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(speed * Time.deltaTime, 0f));
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0f, jumpSpeed * Time.deltaTime));
        }
    }
}