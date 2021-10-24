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

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Movement();
        }
    }

    void Movement()
    {

        boxPosition = transform.position;

        //Forwards and Back
        if (Input.GetKey("s"))
        {
            boxPosition.z = boxPosition.z + moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("w"))
        {
            boxPosition.z = boxPosition.z - moveSpeed * Time.deltaTime;
        }

        //Strafing 
        if (Input.GetKey("d"))
        {
            boxPosition.x = boxPosition.x - moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("a"))
        {
            boxPosition.x = boxPosition.x + moveSpeed * Time.deltaTime;
        }

        transform.position = boxPosition;
        rb.velocity = new Vector3(0, 0, 0);   //Freeze velocity
    }
    }
