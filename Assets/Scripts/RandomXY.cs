using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomXY : MonoBehaviour
{
    public float maxX = 5.0f;
    public float maxY = 5.0f;

    public float minX = -5.0f;
    public float minY = -5.0f;

    public float span = 3;
    private float current;

    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        current = current + Time.deltaTime;

        if (current >= span)
        {
            GameObject bullet = Instantiate(prefab) as GameObject;
            //this.transform.position =
            //    new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), this.transform.position.z);

            bullet.transform.position = this.transform.position;
            bullet.transform.rotation = this.transform.rotation;

            current = 0;
        }
    }

    
}
