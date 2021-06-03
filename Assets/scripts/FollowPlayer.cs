
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform rb;
    public Vector3 offset = new Vector3 (0, 50, -50);

    // Update is called once per frame
    void Update() {
        transform.position = rb.transform.position + offset;
    }
}
