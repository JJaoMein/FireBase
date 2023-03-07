using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.myScore++;

        if (Score.myScore >= Score.highScore)
        {
            Score.highScore = Score.myScore;
        }
    }
}
