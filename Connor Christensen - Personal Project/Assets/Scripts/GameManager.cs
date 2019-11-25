﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public GameObject titleScreen;
    public TextMeshProUGUI instructionsText;
    public Button startButton;
    public Button instructions;
    public Button startInstructions;
    private int score;

    // Start is called before the first frame update
    void Start()
    //Starts score at 0 and helps keep count
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int scoreToAdd)
    {//Adds score to variable
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGame()
    {
        score = 0;
        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);
    }

    public void InstructionsText()
    {
        instructionsText.gameObject.SetActive(true);
        titleScreen.gameObject.SetActive(false);
    }

    public void StartInstructionsGame()
    {
        instructionsText.gameObject.SetActive(false);
    }
}
