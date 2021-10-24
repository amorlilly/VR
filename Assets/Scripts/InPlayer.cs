using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class InPlayer : MonoBehaviour
{
    public bool InRange = false;
    public float speed=5.0f;
    private Vector3 PlayerPos;


    private void Update()
    {
        PlayerPos = GameObject.Find("Main Camera").transform.position;

        if (InRange==true)
        {
            gameObject.transform.position = Vector3.MoveTowards(transform.position, PlayerPos, speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerRange")
        {
            InRange = true;
            Debug.Log("In");
        }
    }
}