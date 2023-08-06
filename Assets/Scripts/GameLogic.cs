using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{

    public static int userScore;
    public static int highScore;
    public Text userScoreText;
    public Text highScoreText;
    public GameObject gameOverScreen;

    public void Start()
    {
        userScore = 0;
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    public void Update()
    {
        userScoreText.text = userScore.ToString();
        highScoreText.text = highScore.ToString();
    }

    public void addScore()
    {
        if (!Control.canMove)
            return;

        userScore++;
        if (userScore > highScore)
            highScore = userScore;
    }

    public void playAgain()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
        PlayerPrefs.Save();
        Control.canMove = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
