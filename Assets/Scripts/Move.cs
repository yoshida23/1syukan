using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    static public GameObject player { get; private set; }
    private Rigidbody rb;

    private float power=3f;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 IdouHoukou = new Vector3(x, y, 0);

        power = 3f;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            power = 6f;
        }

        rb.velocity = IdouHoukou * power;
    }
}
