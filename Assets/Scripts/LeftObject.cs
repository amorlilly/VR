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
        GameObject palm=GameObject.Find("Palm Proxy Transform");

        if (palm == true)
        {
            float tate = palm.transform.localScale.y;

            Vector3 palmpos = palm.transform.position;
            float palmrotex = palm.transform.rotation.x;
            float palmrotey = palm.transform.rotation.y;
            float palmrotez = palm.transform.rotation.z;
            //this.transform.rotation = new Quaternion(palmrotex, palmrotey, palmrotez, 0);
            this.transform.position = palmpos;
        }
    }
}
