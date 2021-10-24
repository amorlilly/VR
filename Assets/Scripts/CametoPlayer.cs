using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CametoPlayer : MonoBehaviour
{
    private Vector3 PlayerPos;

    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPos=GameObject.Find("Main Camera").transform.position;
        this.transform.position = Vector3.MoveTowards(transform.position, PlayerPos, speed*Time.deltaTime);
    }
}
