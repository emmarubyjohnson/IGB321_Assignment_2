using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Anim_Script : MonoBehaviour
{
    public string anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            GetComponent<Animation>().Play(anim);
        }
    }
}
