using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Player;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public bool End = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Time.timeScale = 0.0f;
            GameObject bullet=GameObject.Find("Cube(Clone)");
            Destroy(bullet);
            End = true;
            
            

        }
    }
}
