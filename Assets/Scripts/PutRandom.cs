using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutRandom : MonoBehaviour
{
    public float maxX=5.0f;
    public float maxY=5.0f;
    public float maxZ=5.0f;

    public float minX=-5.0f;
    public float minY=-5.0f;
    public float minZ=-5.0f;

    private int count = 0;

    public int Cubes = 10;

    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        while (count <= Cubes)
        {
            this.transform.position =
                new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));

            GameObject bullet = Instantiate(Bullet)as GameObject;
            bullet.transform.position = this.gameObject.transform.position;
            bullet.transform.rotation = this.transform.rotation;
            count++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
