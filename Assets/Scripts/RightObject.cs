using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        GameObject rightHand=GameObject.Find("Palm Proxy Transform");

        if (rightHand == true)
        {
            this.transform.position = rightHand.transform.position;
            this.transform.rotation = rightHand.transform.rotation;
        }

    }
}
