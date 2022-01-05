using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField]
    GameObject player = default;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec = (player.transform.position - gameObject.transform.position);
        Vector3 vecn = vec.normalized;
        rb.velocity = vecn * 5f;
    }
}
