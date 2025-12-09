using UnityEngine;

public class limbCollision : MonoBehaviour
{
    public playerController plr;

    private void Start()
    {
        plr = GameObject.FindObjectOfType<playerController>().GetComponent<playerController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
         plr.isGrounded = true;
    }
}
