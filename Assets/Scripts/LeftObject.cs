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
        GameObject leftHand = GameObject.Find("Left_HandSkeleton(Clone)");

        if (leftHand == true)
        {
            GameObject LeftPalm = leftHand.transform.Find("Palm Proxy Transform").gameObject;

            if (LeftPalm == true)
            {
                this.transform.position = LeftPalm.transform.position;
                this.transform.rotation = LeftPalm.transform.rotation;
                
            }
        }
    }
}
