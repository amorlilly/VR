using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Image image;
   
    public Text gameover;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (image.fillAmount <= 0)
        {
            Time.timeScale = 0.0f;
            GameObject bullet=GameObject.Find("Cube(Clone)");
            Destroy(bullet);
            gameover.text = "GAME OVER";

        }
        else if(image.fillAmount > 0)
        {
            gameover.text = " ";
        }
    }
}
