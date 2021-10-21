using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCamera : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        GameObject camera=GameObject.Find("Main Camera");

        this.transform.position = camera.transform.position;
        this.transform.rotation = camera.transform.rotation;
    }
}
