using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBox : MonoBehaviour
{
    //Movement
    public float moveSpeed = 7;
    private Vector3 boxPosition;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {            
            if (Input.GetKey("s"))
            {
                rb.velocity = transform.forward * moveSpeed;
            }
            else if (Input.GetKey("w"))
            {
                rb.velocity = -transform.forward * moveSpeed;
            }
            if (Input.GetKey("d"))
            {
                rb.velocity = (Quaternion.Euler(0, -90, 0) * transform.forward) * moveSpeed;
            }
            else if (Input.GetKey("a"))
            {
                rb.velocity = (Quaternion.Euler(0, 90, 0) * transform.forward) * moveSpeed;
            }
        }
        else
        {
            rb.velocity = new Vector3(0,0,0);
        }
    }
}


