using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Bulletshot : MonoBehaviour
{
    public GameObject bullet;

    private float currenttime = 0;
    private float span = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currenttime += Time.deltaTime;

        if (currenttime >= span)
        {
            GameObject bullets=Instantiate(bullet)as GameObject;
            bullets.transform.position = this.transform.position;
            bullets.transform.rotation = this.transform.rotation;

            currenttime = 0.0f;
        }
    }
}
