using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{

    private bool start = false;

    private float staySecond = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start == false)
        {
            Time.timeScale = 0;
        }

        else if (start == true)
        {
            Time.timeScale = 1;
        }
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Wepon")
        {
            staySecond = staySecond + Time.deltaTime;
        }

        if (staySecond >= 3)
        {
            start = true;
        }
    }
}
