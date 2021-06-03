using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce = 1000f;
    public float SideForce = 20f;
    public float WinningZ = 1000f;


    

    // To play with physics, use FixedUpdate
    void FixedUpdate()
    {

        if(rb.transform.position.y <= -1) {
            FindObjectOfType<Gamemanager>().EndGame();
        }

        if(transform.position.z >= WinningZ) {
            // player won!
        }

        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if(Input.GetKey("d"))  {
            rb.AddForce(SideForce, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))  {
            rb.AddForce(-SideForce, 0, 0, ForceMode.VelocityChange);
        }

    }
}
