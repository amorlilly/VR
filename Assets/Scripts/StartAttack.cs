using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAttack : MonoBehaviour
{
    public GameObject Enemy;

    void Start()
    {
        Enemy.SetActive(false);
    }

    void Update()
    {
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "censor")
        {
            Enemy.SetActive(true);
        }
    }
}
