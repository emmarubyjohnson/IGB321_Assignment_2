using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
    }

    private void OnTriggerStay(Collider collider)
    {
        if (collider.tag == "Player" && gameManager.keys > 0)
        {
            Destroy(this.gameObject);
            gameManager.keys -= 1;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
