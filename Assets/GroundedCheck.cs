using UnityEngine;

public class GroundedCheck : MonoBehaviour
{
    // Boolean variable to track contact
    public bool isGrounded = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collider belongs to the surface layer
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Surface"))
        {
            isGrounded = true;
            Debug.Log("Box has touched the surface.");
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        // Reset the boolean when the box no longer touches the surface
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Surface"))
        {
            isGrounded = false;
            Debug.Log("Box is no longer touching the surface.");
        }
    }
}

