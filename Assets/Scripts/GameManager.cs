using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject gameOverCanvas;
    public GameObject scoreCanvas;

    private void Awake()
    {
        gameOverCanvas.SetActive(false);
    }

    private void Start()
    {
        Time.timeScale= 1.0f;

    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
        PlayerPrefs.SetInt("HighScore", Score.highScore);

    }

    public void RePlay()
    {
        SceneManager.LoadScene(0);
    }

}
