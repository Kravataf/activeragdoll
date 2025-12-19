using UnityEngine;

public class grab : MonoBehaviour
{
    public Animator animator;
    GameObject grabbed;
    public Rigidbody rb;
    public int isLeftorRight;
    public bool alreadyGrabbing = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(isLeftorRight))
        {
            if(isLeftorRight == 0)
            {
                animator.SetBool("leftGrab", true);
            } else if(isLeftorRight == 1) {
                animator.SetBool("rightGrab", true);
            }
            FixedJoint fj = grabbed.AddComponent<FixedJoint>();
            fj.connectedBody = rb;
            fj.breakForce = 10000;
        } else if(Input.GetMouseButtonUp(isLeftorRight))
        {
            if(isLeftorRight == 0)
            {
                animator.SetBool("leftGrab", false);
            } else if(isLeftorRight == 1) {
                animator.SetBool("rightGrab", false);
            }
            if(grabbed != null)
            {
                Destroy(grabbed.GetComponent<FixedJoint>());
            }

            grabbed = null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            grabbed = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        grabbed = null;
    }
}
