using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed, jumpForce;
    public Rigidbody hips;
    public bool isGrounded;

    void Start()
    {
        hips = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            hips.AddForce(transform.forward * speed);
        }

        if(Input.GetKey(KeyCode.A))
        {
            hips.AddForce(-transform.right * speed);
        }

        if(Input.GetKey(KeyCode.S))
        {
            hips.AddForce(-transform.forward * speed);
        }

        if(Input.GetKey(KeyCode.D))
        {
            hips.AddForce(transform.right * speed);
        }

        if(Input.GetKey(KeyCode.Space) && isGrounded)
        {
            hips.AddForce(transform.up * jumpForce);
            isGrounded = false;
        }
    }
}
