using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeGet : MonoBehaviour
{
    private float time;

    private bool timestart;
    private bool timeend;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        timestart = false;
        timeend = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (timestart == true&&timeend==false)
        {
            time = time + Time.deltaTime;
        }
        Debug.Log("Start"+timestart);
        Debug.Log("End"+timestart);
        Debug.Log("Time: "+time);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MoveStart")
        {
            timestart = true;
        }

        if (other.gameObject.tag == "HitArea")
        {
            timeend = true;
        }
    }
}
