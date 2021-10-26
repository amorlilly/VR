using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoasterCTRL : MonoBehaviour
{
    public float X = 0;
    public float Y = 0;
    public float Z = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(X, Y, Z);
    }
}
