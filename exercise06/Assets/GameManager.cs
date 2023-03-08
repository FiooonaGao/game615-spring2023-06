using System.Collections; 
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI enemyScoreText;
    public TextMeshProUGUI LoseText;
    public TextMeshProUGUI WinText;

    public int playerScore; 
    public int enemyScore;
    public bool GameOn = false;

    public GameObject winPhoto;
    public GameObject losePhoto;
    public bool GameIsOver = false;

    void Start()
    {
        playerScore = 1;
        enemyScore = 1;
        GameOn = true;
        LoseText.enabled = false;
        WinText.enabled = false;
        GameIsOver = false;
        winPhoto.SetActive(false);
        losePhoto.SetActive(false);
    }


    public void UpdatePlayerScore()
    {
        playerScoreText.text = playerScore.ToString();
        playerScore = playerScore + 1 ;
    }

    public void UpdateEnemyScore()
    {
        enemyScoreText.text = enemyScore.ToString();
        enemyScore = enemyScore + 1;
    }

    void Update()
    {
        if (playerScore >= 12)
        {
            WinText.enabled = true;
            GameOn = false; ;
            GameIsOver = true;
            Invoke("ShowWinPhoto", 2f);


        }
        else if (enemyScore >= 11)
        {
            LoseText.enabled = true;
            GameOn = false;
            GameIsOver = true;
            Invoke("ShowLosePhoto", 2f);
        }
    }
        public void ShowWinPhoto()
        {
            winPhoto.SetActive(true);
        }
    public void ShowLosePhoto()
    {
        losePhoto.SetActive(true);
    }
}


