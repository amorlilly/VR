using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintScore : MonoBehaviour
{
    public Text Board;
    public Text Tokuten;
    public Canvas canvas;
    private RectTransform rt;
    private Score point;

    public bool end=false;

    private void Update()
    {
        point = GameObject.Find("GameCTRL").GetComponent<Score>();

        if (end == true)
        {
            Board.text = "SCORE";
            Tokuten.text = point.score.ToString();

        }
        else if (end == false)
        {
            Board.text = " ";
            Tokuten.text = " ";
        }

        Debug.Log(end);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "End")
        {
            end = true;
        }
    }
}
