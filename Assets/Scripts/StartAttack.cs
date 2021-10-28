using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAttack : MonoBehaviour
{
    public GameObject Enemy;
    private MeshRenderer mash;

    void Start()
    {
        Enemy.SetActive(false);
    }

    void Update()
    {
        mash = this.GetComponent<MeshRenderer>();
        mash.enabled=false;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "censor")
        {
            Enemy.SetActive(true);
        }
    }
}
