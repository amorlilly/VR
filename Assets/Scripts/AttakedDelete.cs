using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.Experimental.StateVisualizer;
using UnityEngine;
using UnityEngine.UI;

public class AttakedDelete : MonoBehaviour
{
    public GameObject Sowrd;

    private Score score;

    public float point = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Player=GameObject.Find("Main Camera");
        
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Wepon")
        {
            score = Sowrd.GetComponent<Score>();
            score.score = score.score + point;
            Destroy(this.gameObject);
            
        }

        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
        
    }
}
