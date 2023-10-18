using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text highScoreText;
    void Start()
    {
        var score = PlayerPrefs.GetInt("score");
        scoreText.text = score.ToString();

        var highScore = PlayerPrefs.GetInt("highScore");
        if(score > highScore)
        {
            PlayerPrefs.SetInt("highScore", score);
            highScore = score;

        }
        highScoreText.text = highScore.ToString();
    }

}
