using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Vector3 PlayerPos;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPos = GameObject.Find("Main Camera").transform.position;
        gameObject.transform.position = Vector3.MoveTowards(transform.position, PlayerPos, 3f * Time.deltaTime);
    }
}
