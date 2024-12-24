using UnityEngine;

public class BowlingBall : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * speed, ForceMode.Impulse);
        }
    }
}
