 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameManager gameManager;

   // public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
    }

    private void OnTriggerStay(Collider collider)
    {
        if (collider.tag == "Player" && Input.GetKey("space")) 
        {
            this.GetComponent<Collider>().enabled = false;

           // door.getComponent<MeshRenderer>()
            gameManager.keys += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
