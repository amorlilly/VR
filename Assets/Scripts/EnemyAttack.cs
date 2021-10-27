using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject player;

    public bool attack = false;

    public float speed = 10;

    private MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (attack == false)
        {
            this.transform.position = this.transform.position;
            mesh.enabled = false;
        }
        else if (attack == true)
        {
            mesh.enabled = true;
            this.transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            this.transform.rotation = new Quaternion(this.transform.rotation.x, this.transform.rotation.y+1, this.transform.rotation.z, this.transform.rotation.z);
        }

        Debug.Log(attack);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerRange")
        {
            attack = true;
        }
    }
}
