using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float FORWARD_FORCE = 5000f;
    public float SIDEWAY_FORCE = 200f;

    // Marked as FixedUpdates because we are using it to mess with physics.
    void FixedUpdate()
    {
        // The reason * Time.deltaTime is to prevent the influence of speed of computers when adding force.
        // The faster a computer is, the smaller the Time.deltaTime value is.
        rb.AddForce(0, 0, FORWARD_FORCE * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(SIDEWAY_FORCE * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-SIDEWAY_FORCE * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
