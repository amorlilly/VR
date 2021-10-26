using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCoasterCamera : MonoBehaviour
{
    public GameObject CoasterCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = CoasterCamera.transform.position;

    }
}
