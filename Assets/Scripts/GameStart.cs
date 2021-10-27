using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{

    private bool start = false;

    public float staySecond = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Time.timeScale = 0;
        //if (start == false)
        //{
        //    Time.timeScale = 0;
        //}

        //else if (start == true)
        //{
        //    Time.timeScale = 1;
        //}

        Debug.Log(staySecond);
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Wepon")
        {
            staySecond = staySecond+1;
        }
    }
}
