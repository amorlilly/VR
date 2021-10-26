using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public float score;

    private float current;

    private float span=1.0f;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        current = current + Time.deltaTime;
        if (span >= current)
        {
            Debug.Log(score);
            current = 0.0f;
        }
    }
}
