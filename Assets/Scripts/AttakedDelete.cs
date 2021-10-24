using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttakedDelete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Player=GameObject.Find("Main Camera");
        

        /*if (Player.transform.position.z - 2 >= this.gameObject.transform.position.z)
        {
            Destroy(this.gameObject);
        }*/
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Wepon")
        {
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
        
    }
}
