using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintScore : MonoBehaviour
{
    public Text Board;
    public Text Tokuten;

    private Score scores;
    private GameOver over;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        over = this.GetComponent<GameOver>();
        scores = this.GetComponent<Score>();

        Board.text = " ";
        Tokuten.text = " ";

        if (over.End == true)
        {
            Board.text = "Score";

            Tokuten.text = scores.score.ToString();
        }
    }
}
