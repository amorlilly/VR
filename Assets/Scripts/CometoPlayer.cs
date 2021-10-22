using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CometoPlayer : MonoBehaviour
{
    public GameObject target;
    public float speed = 10;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, target.transform.position, speed);
    }
}
