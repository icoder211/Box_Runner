using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float rotationSpeed = 40f;

    void FixedUpdate() {
        transform.RotateAround((transform.position), new Vector3(0f, 1f, 0f), rotationSpeed * Time.deltaTime);
        //transform.RotateAround((transform.position), new Vector3(1f, 0f, 0f), 30f * Time.deltaTime);
    }
}
