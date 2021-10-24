using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class InPlayer : MonoBehaviour
{
    public bool InRange = false; 
    public bool Go = false;
    public float speed=5.0f;
    private Vector3 PlayerPos;


    private void Update()
    {
        PlayerPos = GameObject.Find("Main Camera").transform.position;
        MeshRenderer mash = GetComponent<MeshRenderer>();

        if (Go == false)
        {
            StartCoroutine(ChangeGo());
        }

        else if (Go == true)
        {
            if (InRange == true)
            {
                mash.enabled = true;
                gameObject.transform.position =
                    Vector3.MoveTowards(transform.position, PlayerPos, speed * Time.deltaTime);
            }
            else if (InRange == false)
            {
                mash.enabled = false;
            }
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerRange")
        {
            InRange = true;
        }
    }

    private IEnumerator ChangeGo()
    {

        yield return new WaitForSeconds(10);

        Go = true;

    }
}