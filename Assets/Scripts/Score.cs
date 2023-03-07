using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int myScore = 0;
    public static int highScore = 0;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text highScoreText;

    void Start()
    {
        myScore = 0;
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = myScore.ToString();

        if (myScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            highScoreText.text = myScore.ToString();
        }
        
    }
}
