using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObs : MonoBehaviour
{
    public Rigidbody rb;
    public float timePeriod = 2f;
    public float Amplitude = 10f;
    float omega;
    float init;

    // Start is called before the first frame update
    void Start()
    {
        omega = 6.28f / timePeriod;
        init = rb.transform.position.x;
        rb.velocity = new Vector3 (Amplitude * omega, 0f, 0f);
    }

    void FixedUpdate() {
        rb.AddForce(-1 * omega * omega * (rb.transform.position.x - init), 0f, 0f);
    }
}
