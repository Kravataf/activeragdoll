using UnityEngine;

public class copyMotion : MonoBehaviour
{
    public Transform targetLimb;
    ConfigurableJoint cj;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cj = GetComponent<ConfigurableJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        cj.targetRotation = targetLimb.rotation;
    }
}
