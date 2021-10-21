using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAppear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject camera = GameObject.Find("Main Camera");
        float posz = 10;
        float distance = posz - camera.transform.position.z;

        Vector3 min = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
        Vector3 max = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, distance));

        float posx = Random.Range(min.x, max.x);
        //float posy = Random.Range(min.y, max.y);
        float posy = 0;
        this.transform.position = new Vector3(posx, posy, posz);
        this.transform.rotation = camera.transform.rotation;

    }
}
