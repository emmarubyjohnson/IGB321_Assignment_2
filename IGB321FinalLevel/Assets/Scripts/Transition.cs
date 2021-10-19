using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{

    public string level = "Puzzle1_Tile";

    public GameManager gameManager;

    private void OnTriggerStay(Collider collider)
    {
        if (collider.tag == "Player")
        {
            Debug.Log("2");

            SceneManager.LoadScene(level);
            //gameManager.LoadLevel(level);
        }
    }

}
