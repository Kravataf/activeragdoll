using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed, jumpForce;
    public Rigidbody hips;
    public Animator animator;
    public bool isGrounded;

    void Start()
    {
        hips = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalking", true);
            hips.AddForce(transform.forward * speed);
        } else if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("isWalking", true);
            hips.AddForce(-transform.right * speed);
        } else if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isWalking", true);
            hips.AddForce(-transform.forward * speed);
        } else if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("isWalking", true);
            hips.AddForce(transform.right * speed);
        } else
        {
            animator.SetBool("isWalking", false);
        }
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            hips.AddForce(transform.up * jumpForce);
            isGrounded = false;
        } 
    }
}
