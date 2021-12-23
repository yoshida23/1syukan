using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody rb;

    private float power=3f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 IdouHoukou = new Vector3(x, 0, z);

        rb.velocity = IdouHoukou * power;

        rb.constraints = RigidbodyConstraints.FreezeRotation;
        transform.position = new Vector3(
                    Mathf.Clamp(transform.position.x, -5f, 5f),
                    Mathf.Clamp(transform.position.y, 1f, 1f),
                 Mathf.Clamp(transform.position.z, -5f, 5f));
    }
}
