using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    private int currentScore;

    private void Start()
    {
        Bumper.OnAddScore += Bumper_OnAddScore;


        SetScore(0);
    }

    private void Bumper_OnAddScore(object sender, int score)
    {
        currentScore += score;
        SetScore(currentScore);
    }
    private void SetScore(int score)
    {
        currentScore = score;
        scoreText.text = currentScore.ToString();
    }

}
