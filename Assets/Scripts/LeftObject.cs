using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit;
using UnityEngine;

public class LeftObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject palm = GameObject.Find("Palm Proxy Transform");

        if (palm == true)
        {
            this.transform.position = palm.transform.position;
            this.transform.rotation = palm.transform.rotation;

        }
    }
}
